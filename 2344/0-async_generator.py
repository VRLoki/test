#!/usr/bin/env python3
""" Async Generator """

import asyncio
import random
import typing


async def async_generator() -> typing.Generator[float, None, None]:
    """ Async Generator (Returns Generator type due to the yield expr.) """
    for _ in range(10):
        yield random.uniform(0, 10)
        await asyncio.sleep(1)
