using System;

// Class - a new custom data type that defines attributes (member variables) and methods.
// This is like a blueprint to create instances or objects of that class. 
// Ex: A Person has given name and family name

// Instance - a variable whose data type is the class. We odten use the term OBJECT interchangeably.
// Ex: we can have two instances or objects of the Person class: one for John, one for Mary

// Instantiate - a verb that means "to create an instance of."
// Ex: we can instantiate the Person class to create a new object

// Method - a member function. Methods are called using "dot notation" with an instance of the class
// before the dot.
// Ex: person1.GetEasterName()

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
