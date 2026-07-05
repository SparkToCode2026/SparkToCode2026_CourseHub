namespace CsharpFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //built-in functions call 
            // className.functionName(parameters)

            Math.Cos(90);
            Math.Pow(2, 3);    // 2^3 = 8
            Console.WriteLine("hello");
            Console.Clear();

            double r = Math.Cos(90);
            Console.WriteLine(r);

            Console.WriteLine(Math.Pow(2, 3));
            //////////////////////////////////////////

            Console.WriteLine("enter number :");
            float userInput = float.Parse(Console.ReadLine());

            double result = Math.Cos(userInput);
            Console.WriteLine(result);

            /////////////////////////////////////////////////
            Console.WriteLine("enter base number:");
            float baseNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("enter power number:");
            float powerNumber = float.Parse(Console.ReadLine());

            double result2 = Math.Pow(baseNumber, powerNumber);
            Console.WriteLine(result2);
            ////////////////////////////////////////////////

            DateTime currentTiming = DateTime.Now;
            Console.WriteLine(currentTiming);

            DateTime timing = DateTime.Today;
            Console.WriteLine(timing);

            DateTime startSubscription = DateTime.Today;
            DateTime endSubscription = startSubscription.AddDays(30);
            Console.WriteLine("your subscription ends on: " + endSubscription);
            /////////////////////////////////////////

            //string functions format
            // stringName.functionName(parameters)

            Console.WriteLine("enter a word:");
            string word = Console.ReadLine();

            //string word = "Hello, world!";
            int length = word.Length;  // returns 13
                         word.Substring(7, 5);  // returns "world"
            string upperedWord = word.ToUpper();  // returns "HELLO, WORLD!"
            string loweredWord = word.ToLower();  // returns "hello, world!"

            // a is different from A
            // ahmed is equal to AHMED is equal to Ahmed 


            string name = "Ahmed"; //=> AHMED

            Console.WriteLine("enter your name:");
            string input = Console.ReadLine(); //ahmed => AHMED

            if(  input.ToUpper() == name.ToUpper()  )
            {
                Console.WriteLine("welcome to application, succesfull signed on");
            }
            else 
            { 
                Console.WriteLine("invalid name, please try again"); 
            }

            bool containsResult = word.Contains("hi");


        }
    }
}
