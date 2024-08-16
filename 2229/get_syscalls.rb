#!/usr/bin/ruby

require 'open3'

$header_path = "/usr/include/asm"

$types = []
$max_params = 0

def get_prototype(syscall)

	real_syscall = syscall.gsub(/^rt_/, "").gsub(/64$/, "")

	man, err, _ = Open3.capture3("man 2 #{syscall}")

	if !err.empty?
		puts "No manual page found for \"#{syscall}\" (#{real_syscall})"
		return nil
	end

	man = man.strip.match(/SYNOPSIS\s+(.*)\s+DESCRIPTION/m)[1]
		.gsub(/#\s*include.*/, "")
		.gsub(/^\s*/, "")
		.split("\n")

	proto = ""
	man.each do |line|
		line = line.gsub(/\s*\/\*.*\*\/\s*/, "").strip
		proto += " #{line}" if !proto.empty? and !proto.end_with?(";")
		proto += line if proto.empty? and line.match(/#{real_syscall}/)
		break if proto.end_with?(";")
	end

	return proto
end

def get_syscalls(arch="64")

	syscalls = []
	File.read("#{$header_path}/unistd_#{arch}.h").strip.split("\n").each do |line|
		if match = line.match(/__NR_(\S+)\s+(\d+)/)

			proto = get_prototype(match[1])
			if proto == nil or proto.empty?
				syscalls << {
					:name => match[1],
					:id => match[2],
					:ret => "-1",
					:params => []
				}
				next
			end

			const = /(?:const\s*)?/
			struct = /(?:struct)/
			modifiers = /(?:unsigned\s*)?/
			proto_match = proto.match(/^\s*(#{modifiers}\S+(?:\s*\*+)?)[^\(]*\((.*)\);/)

			ret_type = proto_match[1].gsub(/\s+/, "_").gsub(/\*/, "p").gsub(/\.\.\./, "VARARGS").upcase
			$types << ret_type if !$types.include?(ret_type)

			sys_obj = {
				:name => match[1],
				:id => match[2],
				:ret => ret_type,
				:params => []
			}

			params = proto_match[2].split(/,\s*/)
			$max_params = params.count if params.count > $max_params
			params.map do |param|

				# TODO: Param can be an array -> 'char *arr[]''
				type_reg = /^(?:const\s*)?((?:(?:struct|union|enum)\s*)?(?:(?:unsigned|signed)\s*)?\S+(?:\s*\*+)?)/
				param_match = param.match(type_reg)
				if param_match
					p_type = param_match[1].gsub(/\s+/, "_").gsub(/\*/, "p").gsub(/\.\.\./, "VARARGS").upcase
					$types << p_type if !$types.include?(p_type)
					sys_obj[:params] << p_type
				else
					p_type = param.gsub(/\s+/, "_").gsub(/\*/, "p").gsub(/\.\.\./, "VARARGS").upcase
					$types << p_type if !$types.include?(p_type)
					sys_obj[:params] << p_type
				end
			end

			syscalls << sys_obj

		end
	end
	syscalls = syscalls.map do |sys|
		_params = sys[:params] + Array.new($max_params - sys[:params].count, "-1")
		"{\"#{sys[:name]}\", #{sys[:id]}, #{sys[:ret]}, #{sys[:params].count}, {#{_params.join(", ")}}}"
	end

	return syscalls
end

$syscalls_64 = get_syscalls("64")
$syscalls_32 = get_syscalls("32")

puts "Number of 64bit syscalls: #{$syscalls_64.count}"
puts "Number of 32bit syscalls: #{$syscalls_32.count}"

content = File.read("templates/syscalls.h")
	.gsub(/<%MAX_PARAMS%>/, "#{$max_params}")
	.gsub(/<%TYPES%>/, "#{$types.sort.join(",\n\t")}")
	.gsub(/<%SYSCALLS_64%>/, "#{$syscalls_64.join(",\n\t")}")
	.gsub(/<%SYSCALLS_32%>/, "#{$syscalls_32.join(",\n\t")}")

File.open("inc/syscalls.h", "w") { |f| f.puts content }
puts "File inc/syscalls.h written!"
