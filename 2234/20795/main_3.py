#!/usr/bin/python3
""" Test file """
from pymongo import MongoClient
import random
import time
top_students = __import__('101-students').top_students

if __name__ == "__main__":
    client = MongoClient('mongodb://127.0.0.1:27017')
    col = client.tmp_db_3.tmp_col_3
    
    # created 
    j_students = [
        { 'name': "John", 'topics': [{ 'title': "Algo", 'score': 10.3 },{ 'title': "C", 'score': 6.2 }, { 'title': "Python", 'score': 12.1 }]},
        { 'name': "Bob", 'topics': [{ 'title': "Algo", 'score': 5.4 },{ 'title': "C", 'score': 4.9 }, { 'title': "Python", 'score': 7.9 }]},
        { 'name': "Sonia", 'topics': [{ 'title': "Algo", 'score': 14.8 },{ 'title': "C", 'score': 8.8 }, { 'title': "Python", 'score': 15.7 }]},
        { 'name': "Amy", 'topics': [{ 'title': "Algo", 'score': 9.1 },{ 'title': "C", 'score': 14.2 }, { 'title': "Python", 'score': 4.8 }]},
        { 'name': "Julia", 'topics': [{ 'title': "SysAdmin", 'score': 10.5 },{ 'title': "C", 'score': 10.2 }, { 'title': "Python", 'score': 10.1 }]},
        { 'name': "Sanic", 'topics': [{ 'title': "Algo", 'score': 0.3 },{ 'title': "C", 'score': 6.2 }, { 'title': "Python", 'score': 12.1 }]},
        { 'name': "Flask", 'topics': [{ 'title': "Algo", 'score': 15.4 },{ 'title': "C", 'score': 7.9 }]},
        { 'name': "Dylan", 'topics': [{ 'title': "Algo", 'score': 19.8 },{ 'title': "C", 'score': 8.8 }, { 'title': "Java", 'score': 5.7 }]},
        { 'name': "Tom", 'topics': [{ 'title': "Algo", 'score': 7.1 },{ 'title': "C", 'score': 1.2 }, { 'title': "Python", 'score': 4.8 }]},
        { 'name': "Chris", 'topics': [{ 'title': "Algo", 'score': 10.5 },{ 'title': "Python", 'score': 10.1 }]}
    ]
    for j_student in j_students:
        col.insert_one(j_student)

    # Top
    top_students = top_students(col)

    # Display result
    for student in top_students:
        print("{} => {}".format(student.get('name'), student.get('averageScore')))
