#!/usr/bin/env python3
"""Complex types - mixed list"""

from typing import Union, List


def sum_mixed_list(mixed_list: List[Union[int, float]]) -> float:
    """Sum of all floats in a list"""
    return sum(mixed_list)
