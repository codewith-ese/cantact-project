using System;
using System.IO.Compression;
using System.Runtime.Serialization;

public  class LoanForm 
{
    private string _firstName;
    private string _surName;
    private long _phoneNumber;

    public LoanForm(string firstName, string surName, long phoneNumber)
    {
        _surName = surName;
        _phoneNumber = phoneNumber;
        _firstName = firstName;
    }
    public long SetPhoneNumber(long phoneNumber)
    {
        _phoneNumber = phoneNumber;
        return _phoneNumber;
    }
    
    public string SetSurName(string surName)
    {
        _surName = surName;
        return _surName;
    }

    public string SetFirstName(string firstName)
    {
        _firstName = firstName;
        return _firstName;
    }


    public long GetPhoneNumber()
    {
        return _phoneNumber;
    }

    public string GetFirstName()
    {
       
        return _firstName;
    }


    public virtual string GetSurName()
    {
        return _surName;
    }



    public string DisplayContact()
    {
      
        Console.WriteLine($" ====================== ");
        Console.WriteLine($" |  Contact Info:  | ");
        Console.WriteLine($" ====================== ");
        Console.WriteLine($" SurName : {GetSurName()} \n First Name {GetFirstName()} \n Phone Number : {GetPhoneNumber()}");

        return "";
    }

    public virtual string SaveCustomersInfo()
    {
        return "";
    }
 

}


