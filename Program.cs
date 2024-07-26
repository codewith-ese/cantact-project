using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime aDate = DateTime.Now;
        Console.WriteLine("========================      ========================================");
        Console.WriteLine("|| Loan App Program " + "        || " + aDate.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
        Console.WriteLine("========================      ========================================");
      //  Console.WriteLine("");

        var choice = "";
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Apply for Loan  ");
            Console.WriteLine(" 2. Start reflecting activity ");
            Console.WriteLine(" 3. Start listing activity ");
            Console.WriteLine(" 4. Quit ");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();
            if (choice == "1")
            {
                
                Console.Clear();
                Console.WriteLine(" ================================ ");
                Console.WriteLine(" Please fill in your Information  ");
                Console.WriteLine(" ================================ ");
       
                Console.WriteLine(" ");
                var firstNameN ="";
                var lastNameN ="";
                var phoneNumberN = "";
                
               // LoanForm loanForm = new LoanForm("FirstName", "LastName", 0980);
                Customer loanForm = new Customer("FirstName", "LastName", 0980);
         
                Console.Write(" Type First Name :");
                firstNameN = Console.ReadLine();
                Thread.Sleep(2000);

                Console.Write(" Type Last Name :");
                lastNameN = Console.ReadLine();
                
                Console.Write(" Type Phone Number :");
                phoneNumberN = Console.ReadLine();
                int anwser = int.Parse(phoneNumberN);

                loanForm.SetFirstName($" {firstNameN} ");
                loanForm.SetSurName($" {lastNameN} ");
                loanForm.SetPhoneNumber(anwser);

                                // date fucntion 
                DateTime theCurrentTime = DateTime.Now;
                string _date = theCurrentTime.ToShortDateString();

                Console.WriteLine($" Customer saved successfully ");
                Console.WriteLine($" ********************************** ");
                Console.WriteLine($" ww {loanForm.SaveCustomersInfo()}");
                Console.WriteLine($" ww {loanForm.DisplayContact()}");
                Console.WriteLine($" WTM: {theCurrentTime}");
                Console.WriteLine($" ********************************** ");
                Console.WriteLine($" saved successfully ..................");

              //  loanForm.SaveCustomersInfo();

            }
            else if (choice == "2")
            {
                Console.WriteLine(" You choose 2 ");
                // ReflectiinActivity reflectingActivity = new ReflectiinActivity();
                // reflectingActivity.Run();

            }
            else if (choice == "3")
            {

                Console.WriteLine(" You choose 3 ");
            //     ListingActivity listingActivity = new ListingActivity();
            //     listingActivity.Run();
            //    // List<string> a = new List<string>;
               

            }
            else if (choice == "4")
            {
                Console.WriteLine(" Goodbye");

            }
            else
            {
                Console.Write("Invalid Choice. Try Again ");
            }
    
        }
        while (choice !=  "4");

    }
}