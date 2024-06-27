# C# - Data Structures: Arrays, Lists, Dictionaries

## [0. Print an array of integers](./0-print_array/0-print_array.cs)
Write a method that creates and prints an array of integers of a given size.
- Class Name: `Array`
- Prototype: `public static int[] CreatePrint(int size)`
- Returns the new array
- The integers in the array should start with `0` and increment by one until the given size is met (see output below)
- If `size` is `0`, print a blank line
- If `size` is less than `0`, print `Size cannot be negative` and return `null`

## [1. Access an element in an array](./1-element_at/1-element_at.cs)
Write a method that retrieves an element from an array.
- Class Name: `Array`
- Prototype: `public static int elementAt(int[] array, int index)`
- Returns the element at the given index
- If `index` is out of range, print `Index out of range` and return `-1`

## [2. Replace element](./2-replace_element/2-replace_element.cs)
Write a method that replaces an element of an array at a given index.
- Class Name: `Array`
- Prototype: `public static int[] ReplaceElement(int[] array, int index, int n)`
- Returns the updated array
- If `index` is out of range, print `Index out of range` and return the unchanged array

## [3. Print an array of integers... in reverse!](./3-print_array_reverse/3-print_array_reverse.cs)
Write a method that prints all integers of an array, in reverse order.
- Class Name: `Array`
- Prototype: `public static void Reverse(int[] array)`

## [4. Print a list of integers](./4-print_list/4-print_list.cs)
Write a method that creates and prints a list of integers of a given size.
- Class Name: `List`
- Prototype: `public static List<int> CreatePrint(int size)`
- The integers in the list should start with `0` and increment by one until the given `size` is met
- Returns the newly created list
- If `size` is less than `0`, print `Size cannot be negative` and return `null`

## [5. Find the max](./5-max_integer/5-max_integer.cs)
Write a method that finds the biggest integer of a list.
- Class Name: `List`
- Prototype: `public static int MaxInteger(List<int> myList)`
- Returns the largest element in a given list
- If list is empty, print `List is empty` and return `-1`
- You are not allowed to use `LINQ` or `.Max()`

## [6. Only by 2](./6-divisible_by_2/6-divisible_by_2.cs)
Write a method that finds all multiples of 2 in a list.
- Class Name: `List`
- Prototype: `public static List<bool> DivisibleBy2(List<int> myList)`
- Returns a new list containing `true` or `false`, depending on whether the integer at the same position in the original list is a multiple of 2
- The new list should have the same size as the original list

## [7. Delete at](./7-delete_at/7-delete_at.cs)
Write a method that deletes the item at a specific position in a list.
- Class Name: `List`
- Prototype: `public static List<int> DeleteAt(List<int> myList, int index)`
- Returns the updated list
- If `index` is out of range, print `Index is out of range` and return the unchanged list
- You are not allowed to use `.RemoveAt()`

## [8. Number of keys](./8-number_keys/8-number_keys.cs)
Write a method that returns the number of keys in a dictionary.
- Class Name: `Dictionary`
- Prototype: `public static int NumberOfKeys(Dictionary<string, string> myDict)`
- Returns the number of keys in a dictionary
- You are not allowed to use `.Count()`

## [9. Update dictionary](./9-add_key_value/9-add_key_value.cs)
Write a method that adds a key and value to a dictionary.
- Class Name: `Dictionary`
- Prototype: `public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)`
- If a key exists in the dictionary, the value will be replaced
- If a key doesn’t exist in the dictionary, it will be created
- Returns the updated dictionary

## [10. Delete from dictionary](./10-delete_key_value/10-delete_key_value.cs)
Write a method that deletes a key in a dictionary
- Class Name: `Dictionary`
- Prototype: `public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)`
- Returns the updated dictionary

## [11. Multiply by 2](./11-multiply_by_2/11-multiply_by_2.cs)
Write a method that returns a new dictionary with all values multiplied by 2.
- Class Name: `Dictionary`
- Prototype: `public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)`
- Returns the new dictionary

## [12. Print sorted dictionary](./12-print_sorted_dictionary/12-print_sorted_dictionary.cs)
Write a method that prints a dictionary by ordered keys.
- Class Name: `Dictionary`
- Prototype: `public static void PrintSorted(Dictionary<string, string> myDict)`
- You are not allowed to use `SortedDictionary`

## [13. Best score](./13-best_score/13-best_score.cs)
Write a method that returns the key with the biggest integer value in a given dictionary.
- Class Name: `Dictionary`
- Prototype: `public static string BestScore(Dictionary<string, int> myList)`
- Returns the key with the biggest integer value
- You can assume that all values are non-negative integers
- You can assume that all students have a different score
- If no scores are found, return `“None”`

## [14. Rectangular array](./14-rectangular_array/14-rectangular_array.cs)
Write a program that creates and prints a 5 by 5 two-dimensional array and initialize index `[2,2]` to `1` and all other indices to 0.

## [15. Matrix squared](./15-square_matrix/15-square_matrix.cs)
Write a method that computes the square value of all integers of a matrix.
- Class Name: `Matrix`
- Prototype: `public static int[,] Square(int[,] myMatrix)`
- Returns a new matrix containing the square value of all integers of the original matrix

## [16. Jagged array](./100-jagged_array/100-jagged_array.cs)
Write a program that creates and prints a [jagged array](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays) containing 3 arrays.
- The first array should contain `0, 1, 2, 3`
- The second array should contain `0, 1, 2, 3, 4, 5, 6`
- The third array should contain `0, 1`
