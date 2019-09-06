using System;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey you, let's get your average score?");
            Console.WriteLine("First I'll need a few of your scores.");

            Console.Write("What is your first score?  ");
            var firstScore = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your second score?  ");
            var secondScore = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your third score?  ");
            var thirdScore = Convert.ToInt32(Console.ReadLine());

            int averageScore = (firstScore + secondScore + thirdScore) / 3;

            
            Console.WriteLine($"{firstScore} {secondScore} {thirdScore}");

            Console.WriteLine($"Your average score is: {averageScore}!");
        }
    }
}
