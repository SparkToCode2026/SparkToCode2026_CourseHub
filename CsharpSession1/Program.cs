namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to show welcome message


            //Console.Write("Please Enter Your Name: ");
            //string userName = Console.ReadLine();

            //Console.Write("Please Enter Your Age: ");
            //int userAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter your salary: ");
            //float userSalary = float.Parse(Console.ReadLine());


            //Console.WriteLine("hello " + userName + " welcome to spark");
            /////////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("enter first number: ");
            //float firstNumber = float.Parse(Console.ReadLine());

            //Console.WriteLine("enter second number: ");
            //float secondNumber = float.Parse(Console.ReadLine());


            //float additionResult = firstNumber + secondNumber;
            //float subtractionResult = firstNumber - secondNumber;
            //float multiplicationResult = firstNumber * secondNumber;
            //float divisionResult = firstNumber / secondNumber;
            //float reminderResult = firstNumber % secondNumber;
            //bool comparisonResult = firstNumber == secondNumber;
            //bool testResult = !(10 > 5); // false

            //// and:  &&
            //// Or:   ||
            //// not:  !



            //Console.WriteLine("Addition result: " + additionResult);
            //Console.WriteLine("Subtraction result: " + subtractionResult);
            //Console.WriteLine("multiplication result: " + multiplicationResult);
            //Console.WriteLine("Division result: " + divisionResult);
            //Console.WriteLine("Reminder result: " + reminderResult);
            //Console.WriteLine("Comparison result: " + comparisonResult);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("Enter your degree: ");
            //float degree = float.Parse(Console.ReadLine());

            //if(degree >= 0 && degree < 50)
            //{
            //    Console.WriteLine("you failed");
            //}
            //else if(degree >= 50 && degree < 60)
            //{
            //    Console.WriteLine("you passed with Grade: D");
            //}
            //else if(degree >= 60 && degree < 70)
            //{
            //    Console.WriteLine("you passed with Grade: C");
            //}
            //else if (degree >= 70 && degree < 80)
            //{
            //    Console.WriteLine("you passed with Grade: B");
            //}
            //else if(degree > 80)
            //{

            //    Console.WriteLine("you passed with Grade: A");
            //}
            //else
            //{
            //    Console.WriteLine("you entered a wrong number");
            //}

            ///////////////////////////////////////////////////////////////

            Console.WriteLine("welcome to main menu:");
            Console.WriteLine("1.Deposite");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Balance check");

            Console.WriteLine("please choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("deposited");
                    break;


                case 2:
                    Console.WriteLine("withdrawed");
                    break;


                case 3:
                    Console.WriteLine("your balance = ");
                    break;

                default:
                    Console.WriteLine("please choose a correct option");
                    break;
            }
            /////////////////////////////////////////
        }
    }
}
