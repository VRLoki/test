#!/usr/bin/python3
"""Module 2-Rectangle
Defines a Rectangle class.
"""


class Rectangle:
    """Rectangle class defined by width and height."""

    def __init__(self, width=0, height=0):
        if type(width) is not int:
            raise TypeError("width must be an integer")
        if width < 0:
            raise ValueError("width must be >= 0")
        if type(height) is not int:
            raise TypeError("height must be an integer")
        if height < 0:
            raise ValueError("height must be >= 0")
        self.__width = width
        self.__height = height

    @property
    def width(self):
        return self.__width

    @width.setter
    def width(self, k):
        if type(k) is not int:
            raise TypeError("width must be an integer")
        if k < 0:
            raise ValueError("width must be >= 0")
        self.__width = k

    @property
    def height(self):
        return self.__height

    @height.setter
    def height(self, k):
        if type(k) is not int:
            raise TypeError("height must be an integer")
        if k < 0:
            raise ValueError("height must be >= 0")
        self.__height = k

    def area(self):
        return (self.__height * self.__width)

    def perimeter(self):
        if self.__width == 0 or self.__height == 0:
            return 0
        return 2*(self.__height + self.__width)
