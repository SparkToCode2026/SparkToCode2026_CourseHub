using System;

namespace OOP_Part1_TaskSolution
{
    // =====================================================================
    // CLASS 1 - BankAccount
    // =====================================================================
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        // Default constructor (used for the two starting accounts)
        public BankAccount() { }

        // Case 16 - Parameterized constructor (research)
        public BankAccount(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        // Case 18 - Read-only property (research): true when Balance is below 0
        public bool IsOverdrawn
        {
            get { return Balance < 0; }
        }

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

    // =====================================================================
    // CLASS 2 - Student
    // =====================================================================
    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email { get; set; }   // private - only accessible within the class
        int age { get; set; }                // default (private) - only accessible within the class

        // Case 17 - Static field & static method (research)
        public static int TotalStudents;

        public static int GetTotalStudents()
        {
            return TotalStudents;
        }

        // Constructor - counts every Student object created
        public Student()
        {
            TotalStudents++;
        }

        // Case 19 - Write-only property (research): stores a 4-digit PIN, cannot be read back
        private string securityPin;
        public string SecurityPin
        {
            set { securityPin = value; }
        }

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            // code to send email
        }
    }

    // =====================================================================
    // CLASS 3 - Product
    // =====================================================================
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock to complete this sale.");
            }
            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Stock Quantity: " + StockQuantity);
        }

        private void LogTransaction()
        {
            // placeholder representing a transaction being logged
        }
    }

    // =====================================================================
    // PROGRAM - Menu-driven console app
    // =====================================================================
    public class Program
    {
        // Six individual objects - NOT stored in any collection
        static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "karim", Balance = 120 };
        static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

        static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student student2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 70 };

        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };


        //methods / functions
        static void Main(string[] args)
        {
            bool exitApp = false;

            while (exitApp==false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 16: QuickAccountOpening(); break;
                    case 17: TotalStudentsCounter(); break;
                    case 18: OverdrawnAccountCheck(); break;
                    case 19: SetStudentSecurityPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }

                Console.WriteLine("press any key");
                Console.ReadKey();
                Console.Clear();

            }
        }

        // --------------------------- Helpers ---------------------------

        // Lets the user pick account1 or account2
        static BankAccount ChooseAccount()
        {
            Console.Write("Choose account (1 or 2): ");
            string input = Console.ReadLine();
            if (input == "2")
            {
                return account2;
            }
            return account1;
        }

        // Lets the user pick student1 or student2
        static Student ChooseStudent()
        {
            Console.Write("Choose student (1 or 2): ");
            string input = Console.ReadLine();
            if (input == "2")
            {
                return student2;
            }
            return student1;
        }

        // Lets the user pick product1 or product2
        static Product ChooseProduct()
        {
            Console.Write("Choose product (1 or 2): ");
            string input = Console.ReadLine();
            if (input == "2")
            {
                return product2;
            }
            return product1;
        }

        // --------------------------- Cases 1-5 (Easy) ---------------------------

        static void ViewAccountDetails()
        {
            Console.Write("Choose account (1 or 2): ");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                double result = account1.CheckBalance();
                Console.WriteLine("returned balance" + result);
            }
            else if (input == 2)
            {
                double result = account2.CheckBalance();
                Console.WriteLine("returned balance" + result);
            }

            else
            {
                Console.WriteLine("Enter valid account number");

            }

            //alternative way
            
            BankAccount choosen = ChooseAccount();
            choosen.CheckBalance();

        }

        static void UpdateStudentAddress()
        {
            Student student = ChooseStudent();

            Console.Write("Enter new address: ");
            string newAddress = Console.ReadLine();
            student.Address = newAddress;
            Console.WriteLine("Address updated to: " + student.Address);
        }

        static void MakeDeposit()
        {
            BankAccount account = ChooseAccount();
            Console.Write("Enter deposit amount: ");
            try
            {
                double amount = double.Parse(Console.ReadLine());
                account.Deposit(amount);
                Console.WriteLine(account.HolderName + "'s updated balance: " + account.Balance);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount entered.");
            }
        }

        static void MakeWithdrawal()
        {
            BankAccount account = ChooseAccount();
            Console.Write("Enter withdrawal amount: ");
            try
            {
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
                Console.WriteLine("Updated balance: " + account.Balance);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount entered.");
            }
        }

        static void ViewProductDetails()
        {
            Product product = ChooseProduct();
            double totalValue = product.GetInventoryValue();
            Console.WriteLine("Total inventory value: " + totalValue);
        }

        // --------------------------- Cases 6-8 (Medium) ---------------------------

        static void RegisterStudent()
        {
            Student student = ChooseStudent();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            student.Register(email);
            Console.WriteLine(student.Name + " has been registered successfully.");
        }

        static void CompareAccountBalances()
        {
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine(account1.HolderName + " has a higher balance.");
            }
            else if (account2.Balance > account1.Balance)
            {
                Console.WriteLine(account2.HolderName + " has a higher balance.");
            }
            else
            {
                Console.WriteLine("Both accounts have equal balances.");
            }
        }

        static void RestockProduct()
        {
            Product product = ChooseProduct();
            Console.Write("Enter quantity to restock: ");
            try
            {
                int quantity = int.Parse(Console.ReadLine());
                product.Restock(quantity);

                if (product.StockQuantity < 10)
                {
                    Console.WriteLine("Stock level: Low (" + product.StockQuantity + ")");
                }
                else if (product.StockQuantity < 50)
                {
                    Console.WriteLine("Stock level: Moderate (" + product.StockQuantity + ")");
                }
                else
                {
                    Console.WriteLine("Stock level: Well Stocked (" + product.StockQuantity + ")");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid quantity entered.");
            }
        }

        // --------------------------- Cases 9-13 (Hard) ---------------------------

        static void TransferBetweenAccounts()
        {
            Console.WriteLine("Choose SOURCE account:");
            BankAccount source = ChooseAccount();
            Console.WriteLine("Choose DESTINATION account:");
            BankAccount destination = ChooseAccount();

            Console.Write("Enter transfer amount: ");
            try
            {
                double amount = double.Parse(Console.ReadLine());

                if (source.Balance >= amount)
                {
                    source.Withdraw(amount);
                    destination.Deposit(amount);
                    Console.WriteLine("Transfer successful.");
                    Console.WriteLine(source.HolderName + "'s new balance: " + source.Balance);
                    Console.WriteLine(destination.HolderName + "'s new balance: " + destination.Balance);
                }
                else
                {
                    Console.WriteLine("Transfer failed: insufficient balance in source account.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount entered.");
            }
        }

        static void UpdateStudentGrade()
        {
            Student student = ChooseStudent();
            Console.Write("Enter new grade: ");

            int newGrade;
            try
            {
                newGrade = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input: grade must be a number. No change made.");
                return;
            }

            if (newGrade < 0 || newGrade > 100)
            {
                Console.WriteLine("Invalid grade: must be between 0 and 100. No change made.");
                return;
            }

            student.Grade = newGrade;
            Console.WriteLine("Grade updated to: " + student.Grade);
        }

        static void StudentReportCard()
        {
            Student student = ChooseStudent();
            string status = student.Grade >= 60 ? "Pass" : "Fail";

            Console.WriteLine("----- Report Card -----");
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Address: " + student.Address);
            Console.WriteLine("Grade: " + student.Grade);
            Console.WriteLine("Status: " + status);
        }

        static void AccountHealthStatus()
        {
            BankAccount account = ChooseAccount();
            string status;

            if (account.Balance < 50)
            {
                status = "Low Balance";
            }
            else if (account.Balance <= 1000)
            {
                status = "Healthy";
            }
            else
            {
                status = "Premium";
            }

            Console.WriteLine("Account status: " + status);
        }

        static void BulkSaleWithRevenue()
        {
            Product product = ChooseProduct();
            Console.Write("Enter quantity to sell: ");

            try
            {
                int quantity = int.Parse(Console.ReadLine());

                if (product.StockQuantity < quantity)
                {
                    int shortfall = quantity - product.StockQuantity;
                    Console.WriteLine("Not enough stock. You need " + shortfall + " more unit(s) to fulfill this order.");
                }
                else
                {
                    double revenue = quantity * product.Price;
                    product.Sell(quantity);
                    Console.WriteLine("Sale completed. Revenue: " + revenue);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid quantity entered.");
            }
        }

        // --------------------------- Cases 14-15 (Advanced) ---------------------------

        static void ScholarshipEligibilityCheck()
        {
            Student student = ChooseStudent();
            BankAccount account = ChooseAccount();

            bool gradeOk = student.Grade >= 80;
            bool balanceOk = account.Balance >= 100;

            if (gradeOk && balanceOk)
            {
                Console.WriteLine("Eligible for Scholarship Bonus.");
            }
            else if (!gradeOk && !balanceOk)
            {
                Console.WriteLine("Not eligible: grade is below 80 AND balance is below 100.");
            }
            else if (!gradeOk)
            {
                Console.WriteLine("Not eligible: grade is below 80.");
            }
            else
            {
                Console.WriteLine("Not eligible: balance is below 100.");
            }
        }

        static void FullBalanceTopUpFlow()
        {
            BankAccount account = ChooseAccount();

            if (account.Balance < 50)
            {
                double before = account.Balance;
                double topUp = 100 - account.Balance;
                account.Deposit(topUp);
                Console.WriteLine("Balance before top-up: " + before);
                Console.WriteLine("Balance after top-up: " + account.Balance);
            }
            else
            {
                Console.WriteLine("No top-up needed - balance is already 50 or above.");
            }
        }

        // --------------------------- Cases 16-19 (Research) ---------------------------

        static void QuickAccountOpening()
        {
            Console.Write("Enter new account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter holder name: ");
            string holderName = Console.ReadLine();
            Console.Write("Enter starting balance: ");
            double balance = double.Parse(Console.ReadLine());

            BankAccount newAccount = new BankAccount(accountNumber, holderName, balance);

            Console.WriteLine("New account created:");
            Console.WriteLine("Account Number: " + newAccount.AccountNumber);
            Console.WriteLine("Holder Name: " + newAccount.HolderName);
            Console.WriteLine("Balance: " + newAccount.Balance);
        }

        static void TotalStudentsCounter()
        {
            int total = Student.GetTotalStudents();
            Console.WriteLine("Total students registered in the system: " + total);
        }

        static void OverdrawnAccountCheck()
        {
            BankAccount account = ChooseAccount();
            if (account.IsOverdrawn)
            {
                Console.WriteLine("This account is overdrawn.");
            }
            else
            {
                Console.WriteLine("This account is not overdrawn.");
            }
        }

        static void SetStudentSecurityPin()
        {
            Student student = ChooseStudent();
            Console.Write("Enter a 4-digit PIN: ");
            string pin = Console.ReadLine();
            student.SecurityPin = pin;
            Console.WriteLine("PIN set successfully.");
        }
    }
}
