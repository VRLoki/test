#!/usr/bin/python3
""" Test file """
from pymongo import MongoClient
import random
import time
schools_by_topic = __import__('11-schools_by_topic').schools_by_topic

if __name__ == "__main__":
    client = MongoClient('mongodb://127.0.0.1:27017')
    col = client.tmp_db_2.tmp_col_2
    
    # created 
    obj_ids_matched = []
    col.insert_one({ 'name': "doc 4", 'topics': ["topic_4", "topic_5", "topic_6"]})

    # search
    items = schools_by_topic(col, "topic_2")
    for item in items:
        i_id = str(item.get('_id'))
        
        if i_id not in obj_ids_matched:
            print("{} not found".format(i_id))
            exit(0)
        
        obj_ids_matched.remove(i_id)
        
    if len(obj_ids_matched) == 0:
        print("OK", end="")
        exit(0)
    print("Documents not found: {}".format(obj_ids_matched))
