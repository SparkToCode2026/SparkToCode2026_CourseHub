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
        }

       
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
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
