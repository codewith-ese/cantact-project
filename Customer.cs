public class Customer: LoanForm
{


    public Customer(string firstName, string surName, long phoneNumber)
    : base(firstName, surName, phoneNumber)
    {

    }

    public override  string SaveCustomersInfo()
    {
        
                        // date fucntion 
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();

        List<string> strings = new List<string>();
        strings.Add(_date);
        strings.Add(GetFirstName());
        strings.Add(GetSurName());
        // strings.Add(loanForm.GetPhoneNumber());
        

        string filename = $"{GetFirstName()}.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))

        foreach (string a in strings)
        {
            Console.WriteLine(a);
            outputFile.WriteLine($" Prompt : {a}");

        }

        return "";    
        
    }


    
}