#!/usr/bin/env python3
"""LFU Cache system"""

from base_caching import BaseCaching


class LFUCache(BaseCaching):
    """ LFU Cache class
    """
    def __init__(self):
        """ Constructor method
        """
        super().__init__()
        self.use_order_dict = {}
        self.use_order_num = 0
        self.access_count = {}

    def put(self, key, item):
        """Insert data into cache. If multiple same frequently
        use items, use LRU algorithm
        """
        if key is not None and item is not None:
            if key not in self.cache_data:
                if len(self.cache_data) + 1 > BaseCaching.MAX_ITEMS:
                    lfu = min(self.access_count.values())
                    values_count = 0
                    lfu_dict = {}

                    for k, v in self.access_count.items():
                        if self.access_count[k] == lfu:
                            values_count += 1
                            lfu_dict[k] = self.use_order_dict[k]

                    for k, v in self.access_count.items():
                        if values_count == 1 and v == lfu:
                            del self.access_count[k]
                            del self.use_order_dict[k]
                            del self.cache_data[k]
                            print(f'DISCARD: {k}')
                            break
                        else:
                            lru = min(lfu_dict.values())
                            for k, _ in self.use_order_dict.items():
                                if self.use_order_dict[k] == lru:
                                    del self.access_count[k]
                                    del self.cache_data[k]
                                    del self.use_order_dict[k]
                                    print(f'DISCARD: {k}')
                                    break
                            break
                self.access_count[key] = 0
            else:
                self.access_count[key] += 1

            self.cache_data[key] = item
            self.use_order_dict[key] = self.use_order_num
            self.use_order_num += 1

    def get(self, key):
        """Get data from cache"""
        if key is not None and key in self.cache_data:
            self.use_order_dict[key] = self.use_order_num
            self.use_order_num += 1
            self.access_count[key] += 1
            return self.cache_data[key]
        return None
