#!/usr/bin/python3
"""
    Script to list all State, and corresponding City
    object in database hbtn_0e_0_usa

    ARGUMENTS :
            mysql username = user
            mysql password = pswd
            database name = db_name

"""

import sys
from sqlalchemy import (create_engine)
from sqlalchemy.orm import sessionmaker
from relationship_city import City
from relationship_state import State


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

    # create session to save in bd
    session = sessionmaker(bind=engine)()

    # query : table State with all State by asc order
    query = session.query(State).order_by(State.id.asc())
    # each row contain state.id, state.name, state.cities (linked City table)
    for state in query:
        print('{}: {}'.format(state.id, state.name))
        # for each column state.cities access to linked city.id and city.name
        for city in state.cities:
            print('\t{}: {}'.format(city.id, city.name))

    session.close()
