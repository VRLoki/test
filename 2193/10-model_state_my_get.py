#!/usr/bin/python3
"""
    Script to list State contain letter a from database hbtn_0e_0_usa

    ARGUMENTS :
            mysql username = user
            mysql password = pswd
            database name = db_name
            state_name_to_search = search_name

"""

import sys
from sqlalchemy import (create_engine)
from sqlalchemy.orm import sessionmaker
from model_state import Base, State
from model_city	import City

if __name__ == "__main__":
    # Recover argument from user
    user = sys.argv[1]
    pswd = sys.argv[2]
    db_name = sys.argv[3]
    search_name = sys.argv[4]

    # create bd
    engine = create_engine(
        'mysql+mysqldb://{}:{}@localhost/{}'
        .format(user,
                pswd,
                db_name,
                search_name),
        pool_pre_ping=True
    )
    # function to create all tables in the bd engine
    Base.metadata.create_all(engine)

    # create session to save in bd
    Session = sessionmaker(bind=engine)
    session = Session()

    # query + construct string response
    # if no answer print Not found
    query = session.query(State)\
        .filter(State.name == search_name).first()
    if query is not None:
        print(query.id)
    else:
        print("Not found")

    session.close()
