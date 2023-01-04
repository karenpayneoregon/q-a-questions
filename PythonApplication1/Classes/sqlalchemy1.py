#
# Read schena from database created in sqlalchemy_example.py
#
import sqlalchemy as db

engine = db.create_engine('sqlite:///C:\\Work\\school.db')
connection = engine.connect()
metadata = db.MetaData()
students = db.Table('Student', metadata, autoload=True, autoload_with=engine)

print(students.columns.keys())
