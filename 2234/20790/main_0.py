#!/usr/bin/python3
""" Test file """
from pymongo import MongoClient
insert_school = __import__('9-insert_school').insert_school

if __name__ == "__main__":
    client = MongoClient('mongodb://127.0.0.1:27017')
    col = client.tmp_db_0.tmp_col_0
    
    obj_by_id = {}
    obj_id = insert_school(col, name="HBTN")
    if obj_id is None:
        print("Can't insert a document")
        exit(0)
    obj_by_id[obj_id] = { 'name': "HBTN" }
    
    items = col.find()
    for item in items:
        i_id = item.get('_id')
        obj = obj_by_id.get(i_id)
        if obj is None:
            print("{} not found".format(i_id))
            exit(0)
        for key in obj.keys():
            i_value = item.get(key)
            obj_value = obj.get(key)
            if i_value != obj_value:
                print("Wrong value for {}: {} instead of {}".format(i_id, i_value, obj_value))
                exit(0)
        del obj_by_id[i_id]
        
    if len(obj_by_id) == 0:
        print("OK", end="")
        exit(0)
    print("Documents not inserted: {}".format(obj_by_id))
