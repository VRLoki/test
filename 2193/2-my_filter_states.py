#!/usr/bin/python3
"""
    Script to get all states from the database hbtn_0e_0_usa
    where name matches the argument

    ARGUMENTS :
            mysql username
            mysql password
            database name
            state name searched
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
    search_name = sys.argv[4]

    # connect database
    db = MySQLdb.connect(host='localhost', user=user,
                         passwd=pswd, db=db_name, port=3306)

    # create cursor
    cur = db.cursor()

    # executing MySQL Queries in Python
    querry = """SELECT * FROM states WHERE name \
                LIKE BINARY '%{}' ORDER BY states.id ASC"""
    cur.execute(querry.format(search_name))

    # display
    search_state = cur.fetchall()
    for state in search_state:
        print(state)

    # close cursor & db
    cur.close()
    db.close()
