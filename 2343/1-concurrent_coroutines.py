#!/usr/bin/env python3
"""Let's execute multiple coroutines at the same time with async"""

import asyncio
from typing import List
wait_random = __import__("0-basic_async_syntax").wait_random


async def wait_n(n: int, max_delay: int) -> List[float]:
    """Spawn wait_random n times with the specified max_delay."""

    delays = [wait_random(max_delay) for _ in range(n)]
    # asyncio.as_completed() returns an iterator over the given coroutines
    # in the order of their completion.
    return [await delay for delay in asyncio.as_completed(delays)]
