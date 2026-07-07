namespace CsharpCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //grades of students
            int grade1 = 85;
            int grade2 = 90;
            int grade3 = 78;
            int grade4 = 92;

            //collections ( data structures ) of variables
            // collection types: array, list, satck, queue, dictionary, set

            //single variable => holds a single value
            int grade; //decalre a variable to hold a single grade
            grade = 85; //assign a value to the variable
            grade = 69; //reassign or change the value of the variable
            Console.WriteLine(grade); //print the value of the variable

            Console.WriteLine("enter a grade: ");
            grade = int.Parse(Console.ReadLine());
            Console.WriteLine(grade); //print the value of the variable
            ////////////////////////////////////////////////////////////////////////////////////////////////////////


            // array => fixed size, same data type, index based
            // type[] arrayName = new type[size]; //syntax to declare an array
            int[] grades = new int[4]; //declare an array to hold 4 grades
            grades[0] = 85; //assign a value to the first element of the array
            grades[1] = 90; //assign a value to the second element of the array
            grades[2] = 78; //assign a value to the third element of the array
            grades[3] = 92; //assign a value to the fourth element of the array

            //alternative way to declare and initialize an array
            int[] grades2 = new int[] { 85, 90, 78, 92 }; //declare and initialize an array to hold 4 grades
            int[] grades3 = { 85, 90, 78, 92 };

            grades[2] = 55; //reassign or change the value of the third element of the array
            Console.WriteLine(grades[2]); //print the value of the third element of the array


            Console.WriteLine("enter a grade: ");
            grades[2] = int.Parse(Console.ReadLine());
            Console.WriteLine(grades[2]); //print the value of the third element of the array
                                          //////////////////////////////////////////////////////////////////////////



            //List => dynamic size, same data type, index based

            //List<type> listName = new List<type>(); //syntax to declare a list
            List<int> studentsGrades = new List<int>(); //declare a list to hold grades 
            studentsGrades.Add(85); //add a value to the list
            studentsGrades.Add(90); //add a value to the list
            studentsGrades.Add(78); //add a value to the list
            studentsGrades.Add(92); //add a value to the list

            studentsGrades[2] = 55; //reassign or change the value of the third element of the list
            Console.WriteLine(studentsGrades[2]); //print the value of the third element of the list


            Console.WriteLine("enter a grade: ");
            studentsGrades.Add(int.Parse(Console.ReadLine()));

            int length = studentsGrades.Count; //get the number of elements in the list

            Console.WriteLine(studentsGrades[length - 1]); //print the value of the fifth element of the list

            studentsGrades.Remove(55); //remove the first occurrence of the value 55 from the list
            studentsGrades.RemoveAt(2); //remove the element at index 2 from the list ( delete studentGrades[2] )
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Iterate Over Collections ( array, list )
            // for loop

            int counter;
            for(counter = 0; counter < studentsGrades.Count; counter++) // count from 0 to length -1 ( < except last number )
            {
                Console.WriteLine( studentsGrades[counter] ); //print the value of the element at index counter
            }

            // re initite couner ( set counter to 0 ) and iterate again
            for (counter = 0; counter < studentsGrades.Count; counter++)  //reassignment for all values in the list already existing
            {
                Console.WriteLine("enter a grade: ");
                studentsGrades[counter] = int.Parse(Console.ReadLine());
            }


            //adding 10 grades to the list using a for loop
            for (counter = 0; counter < 10; counter++)  //reassignment for all values in the list
            {
                Console.WriteLine("enter a grade: ");
                studentsGrades.Add(int.Parse(Console.ReadLine()));
            }


            //removing any grade that is less than 50 from the list using a for loop ( list already exist )
            for (counter = 0; counter < studentsGrades.Count; counter++)  //reassignment for all values in the list
            {
                if (studentsGrades[counter] < 50)
                {
                    studentsGrades.RemoveAt(counter);
                    counter--; //decrement counter to avoid skipping the next element after removal
                }

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //in stack and queue Order of elements is important, so we will use a different data structure to store them

            //Stack => dynamic size, same data type, LIFO ( last in first out )
            // examples : undo/redo, browser history, call stack, etc.
            //stack<type> stackName = new Stack<type>(); //syntax to declare a stack

            Stack<string> browserhistory = new Stack<string>(); //declare a stack to hold browser history
            browserhistory.Push("google.com"); //add a value to the stack
            browserhistory.Push("amazon.com"); //add a value to the stack
            browserhistory.Push("amazon.com/sell"); //add a value to the stack => Last In

           string result = browserhistory.Peek(); //get the value of the top element of the stack without removing it

           string result2 = browserhistory.Pop(); //remove the top element of the stack ( amazon.com/sell ) Last Out

           int stackLength = browserhistory.Count; // get the number of elements in the stack


            //foreach syntax
            // foreach( type   varName  in  collectionName  )




            //print all the elements in the stack using a foreach loop
            Console.WriteLine("Browser History:");
            foreach (string url in browserhistory)
            {
                Console.WriteLine(url);
            }

            //queue => dynamic size, same data type, FIFO ( first in first out ) / first come first serve 
            // examples: customer service, ticketing system, print queue, etc.
            //Queue <type> queueName = new Queue<type>(); //syntax to declare a queue
            Queue<int> customerNumber = new Queue<int>();
            customerNumber.Enqueue(1); // adding cutomer number 1 to the queue  => First In
            customerNumber.Enqueue(2); // adding cutomer number 2 to the queue
            customerNumber.Enqueue(3); // adding cutomer number 3 to the queue 

            int firstCustomer = customerNumber.Peek(); // get the value of the first element of the queue without removing it
            int firstCutmerRemoved = customerNumber.Dequeue(); // remove the first element of the queue ( customer number 1 ) => First Out
            int queueLength  = customerNumber.Count; // get the number of elements in the queue


            //print all the elements in the queue using a foreach loop
            Console.WriteLine("Customer Numbers:");
            foreach (int number in customerNumber)
            {
                Console.WriteLine(number);
            }
        }
    }
}
