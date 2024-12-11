using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace Assignment_2
{
    class Program
    {
        static void Main()
        {
            #region
            //1-Write a program that allows the user to enter a number then print it.

            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            Console.WriteLine("You entered: " + input);
            #endregion

            #region
            //2-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            int originalValue = 10;
            int copiedValue = originalValue;
            originalValue = 20;
            Console.WriteLine(copiedValue);

            //originalValue=20, copiedValue=10
            #endregion

            #region
            //3-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            Point P1 = new Point();
            Point P2 = new Point();
            P2 = P1;
            P1.X = 5;
            Console.WriteLine(P2.X);
            #endregion
        }

    }
}
