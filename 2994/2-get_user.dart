import '2-util.dart';
import 'dart:async';

Future<void> getUser() async {
  try {
    String userData = await fetchUser();
    print(userData);
  } catch (error) {
    print("error caught: $error");
  }
}
