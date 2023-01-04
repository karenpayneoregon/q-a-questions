#------------------------------------------------------------------
# Main module
# Description
#   Sample code
# Author
#   Karen Payne
# Revisions
#   By              Date        Changes
#   Karen Payne     1/4/2023    Intial creation
#
# Run from terminal
#    python PythonApplication1.py
#------------------------------------------------------------------


#
# Clear the terminal window
#
from ast import Import
from datetime import date
from decimal import Decimal
import os
clear = lambda: os.system('cls')
clear()


#
#   colorama is an external library
#   https://pypi.org/project/colorama/
#
from colorama import Fore, Back, Style, init
init(autoreset=True)
print(Fore.WHITE + Back.BLUE + 'this only works from a windows terminal')

print("")


#
#   We want to create a Taxpayer which resides under the Classes folder so we 
#   must reference Taxpayser with the full path
#
from Classes.TaxpayerClass import Taxpayer

tp = Taxpayer() 
tp.Id = 9
tp.FirstName = "Karen"
tp.LastName = "Payne"
tp.Pin = 3333

print("")
print("Person")

from Classes.PersonClass import Person
person = Person("Karen", "Payne")
print(f'Hello {person.FirstName} {person.LastName}')


#
# Python 3.6 added new string interpolation method called literal string interpolation and introduced a new literal prefix f.
#
# use string interpolation to display properties 
#
print("")
print("Taxpayer")
print(f'Hello {tp.FirstName} {tp.LastName} PIN: {tp.Pin} Id: {tp.Id}')

print("")

#
# Refernce class Room in the file BasicStatements in the folder Learning
#
from Learning.BasicStatements import Room

# create object of Room class
study_room = Room()

# assign values to all the attributes 
study_room.length = 42.5
study_room.breadth = 30.8

# access method inside class
study_room.calculate_area()

print("")

study_room.IfExample()

from Learning.BasicStatements import Sample1

print("")

#
#   Two examples for reading lines in a plain text file
#
Sample1.IterateArray()
Sample1.IterateArrayWithIndex()

# read lines from a text file and print lines to the terminal
with open("LinesFile.txt") as file:
    while (line := file.readline().rstrip()):
        print(line)


print("")

with open("LinesFile.txt") as file_in:
    lines = []
    for line in file_in:
        lines.append(line)
    print



    
# Karen start work on working with SqlLite - works but is slow. 
# TODO work on EF Core 7
# exec(open('Classes\sqlalchemy1.py').read())

#
# Calling C# standard methods and custom code by Karen Payne
#

#from pythonnet import load
import clr

# PythonOedLibrary is a C# library created by Karen Payne
# clr.AddReference is resolved at runtime
clr.AddReference('PythonOedLibrary')
from PythonOedLibrary import EnvironmentOperations

print(EnvironmentOperations.Hello("Karen"))

# from PythonOedLibrary import EnvironmentOperations
# the CLR namespaces are now recognized as Python packages
from System import String
from System import DateTime
from System import Decimal
from System.Collections import *
from System import Environment
userName = Environment.UserName

print("Current user: " + userName)



#
#   try and convert a string to a date
#   dateValue will contain a date reprentation of the first argument to TryParse if the string is a date time
#   otherwise 'ok' will equal false and a message is displayed indicating the string can not represent a date
#
#   ok, parsed in C# is a tuple which allows a method to return two types.
dateValue = DateTime.Now
ok, parsed = DateTime.TryParse("2023-01-01 12:01:00", dateValue)
if ok:
    print(dateValue.ToString("d"))
else:
    print("Date conversion failed")

#
# from decimal to int
#
intValue = Decimal.ToInt32(Decimal(10.142857))
assert isinstance(intValue, int)
print(intValue)
#
# End calling C# standard methods
#



input("Press ENTER to leave")
