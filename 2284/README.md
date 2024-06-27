# C# - Interfaces

## [0. Abstract thinking](./0-abstract_thinking/0-abstract_thinking.cs)
Create an abstract class called `Base` containing the following:
- public property `name`
	- `name` should be a string
- override `ToString()` method to return the following:
	- `<name> is a <type>` (ex. `Garden Gate is a Door`)

## [1. User interface](./1-user_interface/1-user_interface.cs)
Based on `0-abstract_thinking`, create an interface called `IInteractive`.
- method `void Interact()`

Create an interface called `IBreakable`.
- property `durability`
	- `durability` should be an int
- method `void Break()`

Create an interface called `ICollectable`.
- property `isCollected`
	- `isCollected` should be a bool
- method `void Collect()`

You do not need to fully implement the methods for this task.

Create a new class called `TestObject` that inherits from `Base` and all three interfaces.

## [2. Escape room](./2-doors/2-doors.cs)
Based on `1-user_interface`, delete the `TestObject` class. Create a new class called `Door` that inherits from `Base` and `IInteractive`.
- define constructor that sets the value of `name`
	- if `name` isn’t provided, the default value should be `Door`
- implement `Interact()` so that it prints:
	- `You try to open the <name>. It's locked.`

## [3. Interior decorating](./3-decorations/3-decorations.cs)
Based on 2-doors, create a new class called `Decoration` that inherits from `Base`, `IInteractive`, and `IBreakable`.
- add public bool `isQuestItem`
- define constructor that sets the value of `name`, `durability`, and `isQuestItem`
	- the method declaration should use `name`, `durability`, and `isQuestItem` as the parameter names ([why?](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments))
	- if `name` isn’t provided, the default value should be `Decoration`
	- if `durability` isn’t provided, the default value should be `1`
	- if `durability` is 0 or less, throw an exception that states `Durability must be greater than 0`
	- if `isQuestItem` isn’t provided, the default value should be `false`
- implement `Interact()`
	- if the `durability` is `0` or less, print:
		- `The <name> has been broken.`
	- otherwise, if `isQuestItem` is `true`, print:
		- `You look at the <name>. There's a key inside.`
	- if `isQuestItem` is `false`, write:
		- `You look at the <name>. Not much to see here.`
- implement `Break()` so that it decrements `durability` by 1
	- if `durability` is greater than `0`, print:
		- `You hit the <name>. It cracks.`
	- if `durability` is `0`, print:
		- `You smash the <name>. What a mess.`
	- if `durability` is less than `0`, print:
		- `The <name> is already broken.`

## [4. Key collecting](./4-keys/4-keys.cs)
Based on `3-decorations`, create a new class called `Key` that inherits from `Base` and `ICollectable`.
- define constructor that sets the value of `name` and `isCollected`
	- the method declaration should use `name` and `isCollected` as the parameter names
	- if `name` isn’t provided, the default value should be `Key`
	- if `isCollected` isn’t provided, the default value should be `false`
- implement `Collect()`
	- if `isCollected` is `false`, set it to `true` and print:
		- `You pick up the <name>.`
	- if `isCollected` is `true`, print:
		- `You have already picked up the <name>.`

## [5. Iterate and act](./5-iterate_act/5-iterate_act.cs)
Based on 4-keys, create a new class called `RoomObjects` and a method called `IterateAction`. This method should take a list of all objects, iterate through it, and execute methods depending on what interface that item implements. (ex: if the item uses `IInteractive`, your `IterateAction` method should call `Interact()` on it)
- Class: `RoomObjects`
- Prototype: `public static void IterateAction(List<Base> roomObjects, Type type)`

## [6. Better iterating and acting](./6-generic_iteration/6-generic_iteration.cs)
Based on `5-iterate_act`, remove the `RoomObjects` class created in the previous task. Create a new generic class `Objs<T>` that creates a collection of type `T` objects that can be iterated through using `foreach`.
- Class: `Objs<T>`
- `Objs<T>` must inherit from and implement `IEnumerable<T>`
