#!/usr/bin/python3
"""
    Script to print all City object from database hbtn_0e_0_usa

    ARGUMENTS :
            mysql username = user
            mysql password = pswd
            database name = db_name

"""

import sys
from sqlalchemy import (create_engine)
from sqlalchemy.orm import sessionmaker
from model_state import Base, State
from model_city import City

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
    Session = sessionmaker(bind=engine)
    session = Session()

    # get all City order asc city.id
    query = session.query(City).order_by(City.id.asc())
    for row in query:
        print("{}: ({}) {}".format(row.states.name, row.id, row.name))

    session.close()
