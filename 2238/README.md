# C# - Inheritance

## [0. This is one of these](./0-is/0-is.cs)
Write a method that returns `True` if the object is an `int`, otherwise return `False`.
- Class: `Obj`
- Prototype: `public static bool IsOfTypeInt(object obj)`

## [1. For instance](./1-instance/1-instance.cs)
Write a method that returns `True` if the object is an instance of, or if the object is an instance of a class that inherited from, `Array`, otherwise return `False`.
- Class: `Obj`
- Prototype: `public static bool IsInstanceOfArray(object obj)`

## [2. Only subclass](./2-subclass/2-subclass.cs)
Write a method that returns `True` if the object is an instance of a class that inherits from the specified class, otherwise return `False`. The object must be a subclass; your method cannot return `True` if the object is an instance of the base class.
- Class: `Obj`
- Prototype: `public static bool IsOnlyASubclass(Type derivedType, Type baseType)`

## [3. Type](./3-type_get/3-type_get.cs)
Write a method that prints the names of the available properties and methods of an object.
- Class: `Obj`
- Prototype: `public static void Print(object myObj)`

**References**:
- [TypeInfo Class](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.typeinfo?redirectedfrom=MSDN&view=netframework-4.7.2)
- [PropertyInfo Class](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo?redirectedfrom=MSDN&view=netframework-4.7.2)
- [MethodInfo Class](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo?redirectedfrom=MSDN&view=netframework-4.7.2)

## [4. It's not a lesson in classes and inheritance without a Dog](./4-inherit/4-inherit.cs)
Write a empty class `Dog` that inherits from empty class `Animal`.
- Base Class: `Animal`
- Derived Class: `Dog`

## [5. Basic shapes](./5-shape/5-shape.cs)
Write a class `Shape`.
- Class: `Shape`
- public method: `public virtual int Area()`
- Throws an `NotImplementedException` with the message `Area() is not implemented`

## [6. Rectangle](./6-shape/6-shape.cs)
Based on `5-shape`, write a class `Rectangle` that inherits from `Shape`.
- Class: `Rectangle`
	- private field: `private int width`
	- private field: `private int height`
	- public property: `public int Width`
		- `get`: retrieve `width`
		- `set`: if value is negative, throw an `ArgumentException` with the message `Width must be greater than or equal to 0`. Otherwise, set `width` to the value.
	- public property: `public int Height`
		- `get`: retrieve `height`
		- `set`: if value is negative, throw an `ArgumentException` with the message `Height must be greater than or equal to 0`. Otherwise, set `height` to the value.

## [7. Full rectangle](./7-shape/7-shape.cs)
Based on `6-shape`, write a class `Rectangle` that inherits from `Shape`.
- Class: `Rectangle`
	- private field: `private int width`
	- private field: `private int height`
	- public property: `public int Width`
		- `get`: retrieve `width`
		- `set`: if value is negative, throw an `ArgumentException` with the message `Width must be greater than or equal to 0`. Otherwise, set `width` to the value.
	- public property: `public int Height`
		- `get`: retrieve `height`
		- `set`: if value is negative, throw an `ArgumentException` with the message `Height must be greater than or equal to 0`. Otherwise, set `height` to the value.
	- public method: `public new int Area()`
		- This will override the `Area()` method defined in the `Shape` base class. (Try changing `new` to `override` and run the program. What happens?) returns the area of the rectangle
	- public method: `public override string ToString()`
		- returns `[Rectangle] <width> / <height>`

## [8. Square #1](./8-shape/8-shape.cs)
Based on `7-shape`, write a class `Square` that inherits from `Rectangle`
- Class: `Square`
	- private field: `private int size`
	- public property: `public int Size`
		- `get`: retrieve `size`
		- `set`: if value is negative, throw an `ArgumentException` with the message `Size must be greater than or equal to 0`. Otherwise, set `size`, `height`, and `width` to the value.

## [9. Square #2](./9-shape/9-shape.cs)
Based on `8-shape`, write a class `Square` that inherits from `Rectangle`
- Class: `Square`
	- private field: `private int size`
	- public property: `public int Size`
		- `get`: retrieve `size`
		- `set`: if value is negative, throw an `ArgumentException` with the message `Size must be greater than or equal to 0`. Otherwise, set `size`, `height`, and `width` to the value.
	- `Area()` should work **without** writing a new `Area()` method within your `Square` class
	- `.ToString()` should return `[Square] <size> / <size>`
