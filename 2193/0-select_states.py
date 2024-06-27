#!/usr/bin/python3
"""
    Script to get all states from the database hbtn_0e_0_usa

    ARGUMENTS :
            mysql username
            mysql password
            database name
    SORTED BY :
        ASC states.id
"""

if __name__ == '__main__':
    import MySQLdb
    import sys

    # Recover argument from user
    user = sys.argv[1]
    pswd = sys.argv[2]
    db_name = sys.argv[3]

    # connect database
    db = MySQLdb.connect(host='localhost', user=user,
                         passwd=pswd, db=db_name, port=3306)

    # create cursor
    cur = db.cursor()

    # executing MySQL Queries in Python
    cur.execute("SELECT * FROM states ORDER BY states.id ASC")

    # display
    all_states = cur.fetchall()
    for row in all_states:
        print(row)
