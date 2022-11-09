using System;

namespace _014_DataTypes_And_Variables_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boolean Data Type
            bool IsWorking;

            IsWorking = false;
            Console.WriteLine("Is it working?... " + IsWorking);

            IsWorking = true;
            Console.WriteLine("Hmmm... how about now?... " + IsWorking);

            //Math
            int sum, num1, num2;

            num1 = 5;
            num2 = 8;
            sum = num1 + num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
        }
    }
}
