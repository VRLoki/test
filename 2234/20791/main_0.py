#!/usr/bin/python3
""" Test file """
from pymongo import MongoClient
update_topics = __import__('10-update_topics').update_topics

if __name__ == "__main__":
    client = MongoClient('mongodb://127.0.0.1:27017')
    col = client.tmp_db_0.tmp_col_0
    
    update_topics(col, "school", ["Topic 0", "Topic 1", "Topic 2"])

    print("OK", end="")
