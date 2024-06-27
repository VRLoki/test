# Python Variable Annotations

## Introduction

Python is a dynamically-typed language. That means that variable types are dynamically set at run-time, upon assignment of a value to a variable.

For example, in

```python
def fn(a, b):
    return a + b
```

The types of `a` and `b` are not known at build-time, only when `a` and `b` are assigned values at run-time.

Hence, calling

```python
fn("a", 1)
```

somewhere in your code will not raise an exception until the code is actually executed and the function is called:

```
>>> fn("a", 1)
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
TypeError: can only concatenate str (not "int") to str
```

In Python 3, type annotations do not change this. Python is still a dynamically-typed language. Type annotations serve the following purpose:

- Code documentation: thanks to them, a developer reading type-annotated code (his own or someone else's) will know exactly what type each variables is supposed to be. This helps reduce bugs and exceptions and accelerate the development cycle.
- Linting and validation: code editors and continuous integration (CI) pipelines can be configured to automatically validate type-annotated code at build-time and catch bugs before they make it to production.

---

## Resources

[PEP 483 – The Theory of Type Hints](https://peps.python.org/pep-0483/)
[PEP 484 – Type Hints](https://peps.python.org/pep-0484/)
[PEP 526 – Syntax for Variable Annotations](https://peps.python.org/pep-0526/)

[Python Typing Library](https://docs.python.org/3/library/typing.html)

Here are some of the most common annotations. Please, refer to the official documentation for more information.

### Any

Special type indicating an unconstrained type.

- Any is compatible with every type.
- Any assumed to have all methods.
- All values assumed to be instances of Any.

Note that all the above statements are true from the point of view of static type checkers. At runtime, Any should not be used with instance or class checks.

### Union

Union type; `Union[X, Y]` means either X or Y.
To define a union, use e.g. `Union[int, str]`.
You can use `Union[]` to annotate an empty union.

Details:
- The arguments must be types and there must be at least one.
- None as an argument is a special case and is replaced by type(None).
- Unions of unions are flattened, e.g.:
  `Union[Union[int, str], float] == Union[int, str, float]`

- Unions of a single argument vanish, e.g.:

  `Union[int] == int  # The constructor actually returns int`

- Redundant arguments are skipped, e.g.:

  `Union[int, str, int] == Union[int, str]`

- When comparing unions, the argument order is ignored, e.g.:

  `Union[int, str] == Union[str, int]`

- You cannot subclass or instantiate a union.
- You can use `Optional[X]` as a shorthand for `Union[X, None]`.

### Tuple

Tuple type; `Tuple[X, Y]` is the cross-product type of X and Y.

Example: `Tuple[T1, T2]` is a tuple of two elements corresponding to type variables T1 and T2.  `Tuple[int, float, str]` is a `tuple` of an `int`, a `float` and a `string`.

To specify a variable-length tuple of homogeneous type, use `Tuple[T, ...]`.

### Callable

Callable type; `Callable[[int], str]` is a function of `(int) -> str`.

The subscription syntax must always be used with exactly two values: the argument list and the return type.  
The argument list must be a list of types or ellipsis; the return type must be a single type.

There is no syntax to indicate optional or keyword arguments, such function types are rarely used as callback types.

### Type

A special construct usable to annotate class objects.

For example, suppose we have the following classes:

```python
  class User: ...  # Abstract base for User classes
  class BasicUser(User): ...
  class ProUser(User): ...
  class TeamUser(User): ...
```

And a function that takes a class argument that's a subclass of `User` and returns an instance of the corresponding class:

```python
  U = TypeVar('U', bound=User)
  def new_user(user_class: Type[U]) -> U:
      user = user_class()
      # (Here we could write the user object to a database)
      return user

  joe = new_user(BasicUser)
```
At this point the type checker knows that `joe` has type `BasicUser`.

### TypeVar

Type variable.

Usage:

```python
  T = TypeVar('T')  # Can be anything
  A = TypeVar('A', str, bytes)  # Must be str or bytes
```
Type variables exist primarily for the benefit of static type checkers.  They serve as the parameters for generic types as well as for generic function definitions.  See class Generic for more information on generic types.  

Generic functions work as follows:
```python
  def repeat(x: T, n: int) -> List[T]:
      '''Return a list containing n references to x.'''
      return [x]*n

  def longest(x: A, y: A) -> A:
      '''Return the longest of two strings.'''
      return x if len(x) >= len(y) else y
```

The latter example's signature is essentially the overloading of `(str, str) -> str` and `(bytes, bytes) -> bytes`. 
Also note that if the arguments are instances of some subclass of `str`, the return type is still plain `str`.

At runtime, `isinstance(x, T)` and `issubclass(C, T)` will raise `TypeError`.

Type variables defined with covariant=True or contravariant=True can be used to declare covariant or contravariant generic types.
See [PEP 484](https://peps.python.org/pep-0484/) for more details. By default generic types are invariant in all type variables.

Type variables can be introspected. e.g.:

```python
  T.__name__ == 'T'
  T.__constraints__ == ()
  T.__covariant__ == False
  T.__contravariant__ = False
  A.__constraints__ == (str, bytes)
```
Note that only type variables defined in global scope can be pickled.