class Room:
    length = 0.0
    breadth = 0.0
    
    # method to calculate area
    def calculate_area(self):
        print("Area of Room =", self.length * self.breadth)
    # simple if-else
    def IfExample(self):
        if self.length > 0:
            print(f'Length is {self.length}')
        else:
            print("Length is zero")


class Sample1(object):
        
        def IterateArrayWithIndex():

            presidentsLastNames = [
                "Washington", 
                "Adams", 
                "Jefferson", 
                "Madison", 
                "Monroe", 
                "Adams", 
                "Jackson"
             ]

            for index in range(len(presidentsLastNames)):
                print("President {}: {}".format(
                    index + 1, 
                    presidentsLastNames[index]))



        def IterateArray():
            languages = [
                'C#', 
                'Python', 
                'Go', 
                'JavaScript'
            ]

            # access items of a list using for loop
            for language in languages:
                print(language)

# End of class


class Character:  
    def __init__(self, Name): #self is the current instance
        self.name=Name  #set the variable on the instance so that every instance of Character has a name

    def getName(self):  
        return self.name #refer to the name with the instance


    

