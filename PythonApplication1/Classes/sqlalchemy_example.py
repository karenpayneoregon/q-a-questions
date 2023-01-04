#
# Create simple database under C:\Work - does not create the folder so you mus
#
from sqlalchemy import create_engine
from sqlalchemy import Column, Integer, String
from sqlalchemy.ext.declarative import declarative_base

engine = create_engine('sqlite:///C:\\Work\\school.db', echo=True)
Base = declarative_base()


class School(Base):

    __tablename__ = "Student"

    id = Column(Integer, primary_key=True)
    name = Column(String)  


    def __init__(self, name):

        self.name = name    


Base.metadata.create_all(engine)