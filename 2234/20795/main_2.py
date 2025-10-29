#!/usr/bin/python3
""" Test file """
from pymongo import MongoClient
import random
import time
top_students = __import__('101-students').top_students

if __name__ == "__main__":
    client = MongoClient('mongodb://127.0.0.1:27017')
    col = client.tmp_db_2.tmp_col_2
    
    # created 
    j_students = [
        { 'name': "Flask", 'topics': [{ 'title': "Algo", 'score': 15.4 },{ 'title': "C", 'score': 7.9 }]},
        { 'name': "Dylan", 'topics': [{ 'title': "Algo", 'score': 19.8 },{ 'title': "C", 'score': 8.8 }, { 'title': "Java", 'score': 5.7 }]}
    ]
    for j_student in j_students:
        col.insert_one(j_student)

    # Top
    top_students = top_students(col)

    # Display result
    for student in top_students:
        print("{} => {}".format(student.get('name'), student.get('averageScore')))
