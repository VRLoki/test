# C# - if/else, loops, functions

## [0. Positive anything is better than negative nothing](./0-positive_or_negative/0-positive_or_negative.cs)
This program will assign a random signed number to the variable `number` each time it is executed. Complete the [source code](https://github.com/hs-hq/0x01.cs/blob/main/0-positive_or_negative.cs) in order to print whether the number stored in the variable `number` is positive or negative.
- The variable `number` will store a different value every time you will run this program
- You don’t have to understand what `Random` does. Please do not touch this code
- The output of the program should be:
    - The number, followed by
        - if the number is greater than 0: `is positive`
        - if the number is 0: `is zero`
        - if the number is less than 0: `is negative`
    - followed by a new line

## [1. The last digit](./1-last_digit/1-last_digit.cs)
This program will assign a random signed number to the variable `number` each time it is executed. Complete the [source code](https://github.com/hs-hq/0x01.cs/blob/main/1-last_digit.cs) in order to print whether the number stored in the variable `number` is positive or negative.
- The variable `number` will store a different value every time you will run this program
- You don’t have to understand what `Random` does. Please do not touch this code
- The output of the program should be:
    - The string `The last digit of`, followed by
    - the `number`, followed by
    - the string `is`, followed by
        - if the last digit is greater than 5: the digit and `is greater than 5`
        - if the last digit is 0: the digit `and is 0`
        - if the last digit is less than 6 and not 0: the digit and `is less than 6 and not 0`
    - followed by a new line

## [2. I sometimes suffer from insomnia. And when I can't fall asleep, I play what I call the alphabet game](./2-print_alphabet/2-print_alphabet.cs)
Write a program that prints the alphabet, in lowercase, not followed by a new line.
- You can only use `Console.Write` once
- You can only use one loop in your code

## [3. When I was having that alphabet soup, I never thought that it would pay off](./3-print_alphabt/3-print_alphabt.cs)
Write a program that prints the alphabet, in lowercase, not followed by a new line.
- Print all the letters except `q` and `e`
- You can only use `Console.Write` once
- You can only use one loop in your code

## [4. Hexadecimal printing](./4-print_hexa/4-print_hexa.cs)
Write a program that prints all numbers from 0 to 98 in decimal and in hexadecimal (as in the following example)
- You can only use `Console.Write` once
- You can only use one loop in your code

## [5. 00...99](./5-print_comb/5-print_comb.cs)
Write a program that prints numbers from `0` to `99`.
- Numbers must be separated by `,`, followed by a space
- Numbers should be printed in ascending order, with two digits
- The last number should be followed by a new line
- You can only use `Console.Write` no more than twice
- You can only use one loop in your code

## [6. Inventing is a combination of brains and materials. The more brains you use, the less material you need](./6-print_comb2/6-print_comb2.cs)
Write a program that prints all possible different combinations of two digits.
- Numbers must be separated by `,`, followed by a space
- The two digits must be different
- 01 and 10 are considered the same combination of the two digits 0 and 1
- Print only the smallest combination of two digits
- Numbers should be printed in ascending order, with two digits
- The last number should be followed by a new line
- You can only use `Console.Write` and `Console.WriteLine` no more than three times total
- You can only use no more than 2 loops in your code

## [7. islower](./7-islower/7-islower.cs)
Write a method that checks for lowercase character.
- Class Name: `class Character`
- Prototype: `public static bool IsLower(char c)`
- Returns `True` if `c` is lowercase
- Returns `False` otherwise
- You are not allowed to use `Char.IsLower()` or `Char.IsUpper()`

## [8. There are only 3 colors, 10 digits, and 7 notes; its what we do with them that's important](./8-print_last_digit/8-main.cs)
Write a method that prints the last digit of a number.
- Class Name: `class Number`
- Prototype: `public static int PrintLastDigit(int number)`
- Returns the value of the last digit

## [9. a + b](./9-add/9-add.cs)
Write a method that adds two integers and returns the result.
- Class Name: `class Number`
- Prototype: `public static int Add(int a, int b)`
- Returns the value of a + b

## [10. The shortest distance between two points is a straight line](./10-print_line/10-main.cs)
Write a method that draws a straight line in the terminal.
- Class Name: `class Line`
- Prototype: `public static void PrintLine(int length)`
- Where `length` is the number of times the character `_` should be printed
- The line should end with a new line
- If `length` is `0` or less, the function should only print a new line

## [11. I feel like I am diagonally parked in a parallel universe](./11-print_diagonal/11-main.cs)
Write a method that draws a diagonal line in the terminal.
- Class Name: `class Line`
- Prototype: `public static void PrintDiagonal(int length)`
- Where `length` is the number of times the character `\` should be printed
- The line should end with a new line
- If `length` is `0` or less, the function should only print a new line

## [12. Fizz Buzz](./12-fizzbuzz/12-fizzbuzz.cs)
Write a program that prints the numbers from 1 to 100 separated by a space.
- For multiples of three print `Fizz` instead of the number and for multiples of five print `Buzz`.
- For numbers which are multiples of both three and five print `FizzBuzz`.
- Each element should be followed by a space
- The last element should be followed by a new line