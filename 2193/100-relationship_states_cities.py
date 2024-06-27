#!/usr/bin/python3
"""
    Script to add State object "California"
    with City "San Francisco"
    to database hbtn_0e_0_usa

    ARGUMENTS :
            mysql username = user
            mysql password = pswd
            database name = db_name

"""

import sys
from sqlalchemy import (create_engine)
from sqlalchemy.orm import sessionmaker
from relationship_city import City
from relationship_state import Base, State

if __name__ == "__main__":
    # Recover argument from user
    user = sys.argv[1]
    pswd = sys.argv[2]
    db_name = sys.argv[3]

    # create bd
    engine = create_engine(
        'mysql+mysqldb://{}:{}@localhost/{}'
        .format(user,
                pswd,
                db_name),
        pool_pre_ping=True
    )
    # function to create all tables in the bd engine
    Base.metadata.create_all(engine)

    # create session to save in bd
    session = sessionmaker(bind=engine)()

    # create state and city
    new_state = State(name='California')
    new_city = City(name='San Francisco')
    # link new state and new city + save session
    new_state.cities.append(new_city)
    session.add(new_state)
    session.commit()

    session.close()
