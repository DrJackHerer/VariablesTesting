using System;

namespace Variables_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName; //Declaration Syntax

            dogName = "Richard"; //Initialization Syntax

            int dogAge = 5; //Declaring And Intitializing Syntax

            char firstInitial = 'R';

            bool isHungry = true;

            double dogWeight = 10.5; //decimals

            decimal dogHeight = 14.7m; //ends with m

            Console.WriteLine($"My Dogs Name is {dogName} he is {dogAge} years old, he weighs {dogWeight}ibs. He is {dogHeight}inches tall.");

            //Console.WriteLine("It is" + isHungry + "hes always hungry");

            Console.WriteLine("it is" + isHungry + "hes always hungry"); //string interpollation

        }
    }
}
