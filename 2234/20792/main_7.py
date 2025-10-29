#!/usr/bin/python3
""" Test file """
from pymongo import MongoClient
import random
import time
schools_by_topic = __import__('11-schools_by_topic').schools_by_topic

if __name__ == "__main__":
    client = MongoClient('mongodb://127.0.0.1:27017')
    col = client.tmp_db_7.tmp_col_7
    
    # created 
    obj_ids_matched = []
    obj_ids_matched.append(str(col.insert_one({ 'name': "doc 0", 'topics': ["topic_2"]}).inserted_id))
    obj_ids_matched.append(str(col.insert_one({ 'name': "doc 1", 'topics': ["topic_2"]}).inserted_id))
    obj_ids_matched.append(str(col.insert_one({ 'name': "doc 2", 'topics': ["topic_2"]}).inserted_id))
    
    col.insert_one({ 'name': "doc 3", 'topics': ["topic_3"]})
    col.insert_one({ 'name': "doc 4", 'topics': ["topic_4"]})

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
