using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //METHODS
            //Practice problems. DO IT

            ////fav food
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("What is your favorite food?");
            //string food = Console.ReadLine();

            //FavoriteFood(name, food);

            //Console.WriteLine("Yeah, well,");
            //FavoriteFood("Matt", "sushi");

            //Console.WriteLine("And I don't suppose you want to know my favorite food.");
            //FavoriteFood("Computer", "neuro toxins");
            //System.Threading.Thread.Sleep(4000);
            //Console.WriteLine("Don't judge me.");
            //System.Threading.Thread.Sleep(1000);
            //Console.WriteLine("We all have our addictions");

            //System.Threading.Thread.Sleep(2000); 

            //string friend;
            //Console.WriteLine("Now go get a friend.");
            //System.Threading.Thread.Sleep(2000);
            //Console.WriteLine("Do you have a friend with you?");

            //friend = Console.ReadLine().Trim().ToLower();

            //while (friend == "yes")
            //{
            //    Console.WriteLine("I'm talking to your friend now.");
            //    System.Threading.Thread.Sleep(500);
            //    Console.WriteLine("What is YOUR name?");
            //    string nname = Console.ReadLine();

            //    Console.WriteLine("What is YOUR favorite food?");
            //    string nfood = Console.ReadLine();

            //    FavoriteFood(nname, nfood);
            //    Console.WriteLine("Now you see I'm great.");

            //    Console.WriteLine("Do you have another friend with you?");
            //    friend = Console.ReadLine().Trim().ToLower();
            //}


            //Console.WriteLine("Well, I'm great, and that's all you need.");

            //Next do it
            //Retirement calculator

            RetirementCalculator(50);
            RetirementCalculator(70);
            //how to get rid of negative number?
            //Let's go back to the method. 
            //C# functionality! In the library is MATH
            //That's MATHEMATICAL!
            Console.WriteLine("I'd really like to know when you will retire");
            Snark("");
            Console.WriteLine("Because, you see, computers don't retire.");
            Snark("");


            //Wage Calculator
            Console.WriteLine("How many hours did you work this month?");
            double hours = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your hourly wage?");
            Console.Write("$");
            double hourWage = double.Parse(Console.ReadLine());

            MonthlyWageCalculator(hours, hourWage);

            Console.WriteLine("n");

            Console.WriteLine("Income?");
            Console.Write("$");
            double income = double.Parse(Console.ReadLine());
            Console.WriteLine("Expenses?");
            Console.Write("$");
            double expenses = double.Parse(Console.ReadLine());

            SavingsCalculator(income, expenses);

            Console.WriteLine("Throw me a number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(EvenOdd(number));


        }
        //favorite food method
        public static void FavoriteFood(string name, string food)
        {
            Console.WriteLine("**********************************");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(name + "'s favorite food is " + food);
            Console.WriteLine();
        }

        //retirement calculator
        public static void RetirementCalculator(int age)
        {

            int retirementAge = Math.Max(0, 65 - age); //.Max picks the greater of two values. Will return the greater.

            Console.WriteLine("The user will retire in " + retirementAge + " years.");

        }
        //Snarky system pause
        public static void Snark(string snark)
        {
            System.Threading.Thread.Sleep(2500);
        }

        //Wage Calculator
        public static double MonthlyWageCalculator(double hours, double hourWage)
        {
            double monthWage = hours * hourWage;
            Console.WriteLine("Your wage this month is $" + monthWage + ".");
            return monthWage;

        }

        //Savings
        public static double SavingsCalculator(double income, double expenses)
        {
            if (income > expenses)
            {
                double savings = (income - expenses) * .15;
                Console.WriteLine("Set aside $" + savings + " this month.");
                return savings;
            }
            else
            {
                Console.WriteLine("Nothing to save this month.");
                return 0;
            }
        }
            
            //Even Odd

        public static string EvenOdd(int number)
        {
            string answer;
            if(number %2 == 0)
            {
                answer = "Your number is even.";
                return answer;
            }
            else
            {
                answer = "Your number is odd";
                return answer;
            }
                
        }



    }





}

