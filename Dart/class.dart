class Person {
  // underscore = private
  // not sure why anything but late breaks the constructor
  late String _name;
  late int _age;

  Person(String name, int age) {
    _name = name;
    _age = age;
  }

  String get name {
    return _name;
  }

  int get age {
    return _age;
  }

  @override
  String toString() {
    // I guess like Julia, you can skip the {} / ()
    return 'Some $_age-year-old named $_name';
  }
}

void main() {
  var me = Person('99TheDark', 14);
  print(me);
}
