#!/usr/bin/python3
""" Test file """
from pymongo import MongoClient
list_all = __import__('8-all').list_all

if __name__ == "__main__":
    client = MongoClient('mongodb://127.0.0.1:27017')
    col = client.tmp_db_2.tmp_col_2
    
    # insert 5 documents
    names = []
    for i in range(5):
        name = "HBTN {}".format(i)
        col.insert_one({ 'name': name })
        names.append(name)

    items = list_all(col)
    for item in items:
        i_name = item.get('name')
        if i_name in names:
            names.remove(i_name)
    if len(names) == 0:
        print("OK", end="")
        exit(0)
    print("Wrong output: {}".format(list(items)))
