#!/usr/bin/env python3
"""a Python script that interacts with MongoDB"""


def top_students(mongo_collection):
    """A function that returns all students sorted by average score"""

    pipeline = [
        {
            "$project":
                {
                    "name": "$name",
                    "averageScore": {"$avg": "$topics.score"}
                }
        },
        {
            "$sort":
                {
                    "averageScore": -1
                }
        }
    ]
    return list(mongo_collection.aggregate(pipeline))
