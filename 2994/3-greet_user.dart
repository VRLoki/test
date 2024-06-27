import 'dart:convert';
import 'dart:async';
import '3-util.dart';

Future<String> greetUser() async {
  try {
    final userData = await fetchUserData();
    final data = json.decode(userData);
    return "Hello ${data['username']}";
  } catch (e) {
    print('error caught: $e');
    return "";
  }
}

Future<String> loginUser() async {
  try {
    if (await checkCredentials()) {
      print("There is a user: true");
      return await greetUser();
    } else {
      print("There is a user: false");
      return "Wrong credentials";
    }
  } catch (e) {
    return "error caught $e";
  }
}

main() async {
  print(await loginUser());
}
