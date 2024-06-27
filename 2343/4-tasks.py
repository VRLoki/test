#!/usr/bin/env python3
"""Tasks"""

import asyncio
from typing import List
task_wait_random = __import__("3-tasks").task_wait_random


async def task_wait_n(n: int, max_delay: int) -> List[float]:
    """Spawn wait_random n times with the specified max_delay."""

    delays = [task_wait_random(max_delay) for _ in range(n)]
    # asyncio.as_completed() returns an iterator over the given coroutines
    # in the order of their completion.
    return [await delay for delay in asyncio.as_completed(delays)]