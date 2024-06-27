import '6-password.dart';

class User extends Password {
  String? name;
  int? age;
  double? height;
  int? id;
  String user_password = "";

  User({this.id, this.name, this.age, this.height, String? user_password}) : super(password: user_password ?? '') {
    this.user_password = user_password ?? '';
  }

  Map toJson() {
    return {
      'id': this.id,
      'name': this.name,
      'age': this.age,
      'height': this.height
      // 'user_password': this.user_password,
    };
  }

  static User fromJson(Map<dynamic, dynamic> userJson) {
    return User(
      name: userJson["name"],
      age: userJson["age"],
      height: userJson["height"],
      id: userJson["id"],
      user_password: userJson["user_password"] ?? '',
    );
  }

  @override
  String toString() {
    final pass = Password(password: this.user_password);

    return 'User(id : ${this.id} ,name: ${this.name}, age: ${this.age}, height: ${this.height}, Password: ${pass.isValid()})';
  }
}
