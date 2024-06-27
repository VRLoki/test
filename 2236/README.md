# C# - Classes and Namespaces

## [0. Braaainsss](./0-enemy/0-enemy.cs)
Create a new namespace `Enemies`. Create an empty public class `Zombie` within `Enemies` that defines a zombie.

## [1. Healthy competition](./1-enemy/1-enemy.cs)
Based on `0-enemy`, write a public class `Zombie` that defines a zombie by:
- public field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
	- sets the value of `health` to `0`

## [2. Health validation](./2-enemy/2-enemy.cs)
Based on `1-enemy`, write a public class `Zombie` that defines a zombie by:
- public field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
	- sets the value of `health` to `0`
- a new public constructor: `public Zombie(int value)`
	- `value` must be greater than or equal to `0`
	- if `value` is less than 0, throw an `ArgumentException` with the message `Health must be greater than or equal to 0`

## [3. Zombie health](./3-enemy/3-enemy.cs)
Based on `2-enemy`, write a public class `Zombie` that defines a zombie by:
- **private** field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
	- sets the value of `health` to `0`
- public constructor: `public Zombie(int value)`
	- `value` must be greater than or equal to `0`
- public method `public int GetHealth()` that returns the value of health of the Zombie object

## [4. Hello, my name is](./4-enemy/4-enemy.cs)
Based on `3-enemy`, write a public class `Zombie` that defines a zombie by:
- private field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
	- sets the value of `health` to `0`
- public constructor: public Zombie(int value)
	- value must be greater than or equal to `0`
- private field `name`
- `name` should be a string and have a default value of `(No name)`
- public property `Name`
	- `get`: retrieve name
	- `set`: set name
- public method `public int GetHealth()` that returns the value of health of the Zombie object

## [5. Printing a zombie](./5-enemy/5-enemy.cs)
Based on `4-enemy`, write a public class `Zombie` that defines a zombie by:
- private field `health`
- `health` should be an int and have no value
- public constructor: `public Zombie()`
	- sets the value of `health` to `0`
- public constructor: public Zombie(int value)
	- value must be greater than or equal to `0`
- private field `name`
- `name` should be a string and have a default value of `(No name)`
- public property `Name`
	- `get`: retrieve name
	- `set`: set name
- public method `public int GetHealth()` that returns the value of health of the Zombie object
- public `.toString()` override that prints the Zombie object’s attributes to stdout
	- Format: `Zombie Name: <name> / Total Health: <health>`
