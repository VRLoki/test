class Password {
  String password = "";

  bool isValid() {
    return password.length >= 8 &&
        password.length <= 16 &&
        password.contains(RegExp(r'[A-Z]')) &&
        password.contains(RegExp(r'[a-z]')) &&
        password.contains(RegExp(r'[0-9]'));
  }

  @override
  String toString() {
    return "Your Password is: $password";
  }
}
