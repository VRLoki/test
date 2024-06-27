.PHONY: build run stop clean test help

build: ## Compile the source code of the application
	go build -o awesome-api

run: ## Run the application in the background and write logs to awesome-api.log
	./awesome-api >./awesome-api.log 2>&1 &

stop: ## Stop the running application
	pkill awesome-api

clean: ## Stop the application and delete the binary and log files
	$(MAKE) stop || true
	rm -rf awesome-api awesome-api.log

test: ## Test the application by making requests
	curl http://localhost:9999
	curl http://localhost:9999/health

help: ## Displays the list of targets and their use
	@grep -E -i [a-z]+:.# Makefile | tr -d '##'
