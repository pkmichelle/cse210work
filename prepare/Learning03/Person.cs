using System;

public class Person
{
    //as a general rule, attributes should be made private. other classes should not know the details
    //of how the class stores its info. instead the other parts of the program should ask the class
    //to perform tasks related to that information through public methods
    private string _title;
    private string _firstName;
    private string _lastName;

    //many methods (member functions) of a class are public.
    //Often, a public method will have internal steps or computations to perform to help it do its job.
    //these "helper functions" are often private because only the code in the class needs to see it

    public string GetInformalSignature()
    {
        return "Thanks," + _firstName;
    }
    public string GetFormalSignature()
    {
        return "Sincerely," + GetFullName();
    }
    //this helps the other method to function 
    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }

    //when you feel that other parts of the program need access to a member variable
    //instead of making the variable public, create methods to get and set the value
    //this ensures that the class still controls access over the hidden variables

    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }
}