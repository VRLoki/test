#!/usr/bin/env python3
""" Async Comprehensions """

import asyncio
import time
async_comp = __import__('1-async_comprehension').async_comprehension


async def measure_runtime() -> float:
    """ measure_runtime """
    t0 = time.perf_counter()
    await asyncio.gather(*[async_comp() for _ in range(4)])
    return time.perf_counter() - t0
