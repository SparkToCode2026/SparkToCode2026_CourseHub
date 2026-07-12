namespace OOP_Part1
{

    //class className
    //{

    //set of properties and methods / functions

    //}


    public class BankAccount
    {
        //properties
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        //methods

        public void Deposit(double amount)
        {
            Balance += amount;

            SendEmail();
        }

       
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }

            SendEmail();
        }


        public double CheckBalance()
        {
            PrintInformation();

            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Name : " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }

        private void SendEmail()
        { 
        
           // some code to send email with operation information
        }

    }

    public class Student
    {
        //properties (store multiple data/ information)
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email { get; set; } // private property, can only be accessed within the class
        int age {  get; set; } // default access private property, can only be accessed within the class

        //methods (functions)
        public void Register(string Email)
        {
            email = Email;

            SendEmail();
        }

        private void SendEmail()
        {
            //code to send email
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            //variables ( store individual data/ single information)
            // primitives / predefined data types ( int, string, float, double, char, bool)
            int grade1; // declare a variable of type int / stored in stack memory ( fixed size)          
            grade1 = 60; //assign a value to the variable
            Console.WriteLine("Grade: " + grade1);


            string name1 = "John";
            string address1 = "Muscat";

            //create an object of the class, class is a user defined data type, object is an instance of the class
            Student s1 = new Student(); // declare variable or create an object of the class Student
                                        // store in heap memory (dynamic size)
                                        // Student() is a constructor of the object of the class Student

            s1.Name = "Ali";
            s1.Address = "Muscat";
            s1.Grade = 65;
            // s1.email = "karim@gmail"; // cannot access private property outside the class
            s1.Register("karim@gmail");

            Console.WriteLine("Student Name: " + s1.Name);
            Console.WriteLine("Student Address: " + s1.Address);
            Console.WriteLine("Student Grade: " + s1.Grade);



            Student s2 = new Student();
            s2.Name = "Ahmed";
            s2.Address = "Muscat";
            s2.Grade = 70;
            ///////////////////////////////////////////////////////////////////////


            //access modifiers (public, private, protected, internal)
            // how to use proper access modifier ( Encapsulation )

            ///////////////////////////////////////////////////////////////////////

            BankAccount B1 = new BankAccount();
            B1.AccountNumber = 1163;
            B1.HolderName = "karim";
            B1.Balance = 120;


            // B1.PrintInformation(); private method / function
            double result1 = B1.CheckBalance();
            B1.Deposit(30);


            BankAccount B2 = new BankAccount();
            B2.AccountNumber = 15203;
            B2.HolderName = "Ali";
            B2.Balance = 63;

            double result2 = B2.CheckBalance();


        }
    }

}


//static void Main(string[] args)
//{
//    bool exitApp = false;

//    while (exitApp == false)
//    {
//        Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
//        Console.WriteLine(" 1. View Account Details");
//        Console.WriteLine(" 2. Update Student Address");
//        Console.WriteLine(" 3. Make a Deposit");
//        Console.WriteLine(" 4. Make a Withdrawal");
//        Console.WriteLine(" 5. View Product Details");
//        Console.WriteLine(" 6. Register a Student");
//        Console.WriteLine(" 7. Compare Two Account Balances");
//        Console.WriteLine(" 8. Restock Product & Stock Level Check");
//        Console.WriteLine(" 9. Transfer Between Accounts");
//        Console.WriteLine("10. Update Student Grade (Validated)");
//        Console.WriteLine("11. Student Report Card");
//        Console.WriteLine("12. Account Health Status");
//        Console.WriteLine("13. Bulk Sale With Revenue Calculation");
//        Console.WriteLine("14. Scholarship Eligibility Check");
//        Console.WriteLine("15. Full Balance Top-Up Flow");
//        Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
//        Console.WriteLine("17. Total Students Counter (Static Field & Method)");
//        Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
//        Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
//        Console.WriteLine("20. Exit");
//        Console.Write("Choose an option: ");

//        int choice;
//        try
//        {
//            choice = int.Parse(Console.ReadLine());
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
//            continue;
//        }

//        switch (choice)
//        {
//            case 1: ViewAccountDetails(); break;
//            case 2: UpdateStudentAddress(); break;
//            case 3: MakeDeposit(); break;
//            case 4: MakeWithdrawal(); break;
//            case 5: ViewProductDetails(); break;
//            case 6: RegisterStudent(); break;
//            case 7: CompareAccountBalances(); break;
//            case 8: RestockProduct(); break;
//            case 9: TransferBetweenAccounts(); break;
//            case 10: UpdateStudentGrade(); break;
//            case 11: StudentReportCard(); break;
//            case 12: AccountHealthStatus(); break;
//            case 13: BulkSaleWithRevenue(); break;
//            case 14: ScholarshipEligibilityCheck(); break;
//            case 15: FullBalanceTopUpFlow(); break;
//            case 16: QuickAccountOpening(); break;
//            case 17: TotalStudentsCounter(); break;
//            case 18: OverdrawnAccountCheck(); break;
//            case 19: SetStudentSecurityPin(); break;
//            case 20:
//                exitApp = true;
//                Console.WriteLine("Goodbye!");
//                break;
//            default:
//                Console.WriteLine("Invalid option, please choose between 1 and 20.");
//                break;
//        }
//    }
//}