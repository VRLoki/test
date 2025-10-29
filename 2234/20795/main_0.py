#!/usr/bin/python3
""" Test file """
from pymongo import MongoClient
import random
import time
top_students = __import__('101-students').top_students

if __name__ == "__main__":
    client = MongoClient('mongodb://127.0.0.1:27017')
    col = client.tmp_db_0.tmp_col_0
    
    # created 
    j_students = [
    ]
    for j_student in j_students:
        col.insert_one(j_student)

    # Top
    top_students = top_students(col)

    # Display result
    for student in top_students:
        print("{} => {}".format(student.get('name'), student.get('averageScore')))
