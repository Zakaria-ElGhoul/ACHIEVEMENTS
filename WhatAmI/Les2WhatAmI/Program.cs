using System;

namespace Les2WhatAmI
{
    class Program
    {
        static void Main(string[] args)
        {
           // Names
           string firstName = Console.ReadLine();
           string secondName = Console.ReadLine();
           string thirdName = Console.ReadLine();
           string fourthName = Console.ReadLine();

           // Instances
           Player firstplayer = new Player(firstName);
           Player secondplayer = new Player(secondName);
           Player thirdplayer = new Player(thirdName);
           Player fourthPlayer = new Player(fourthName);

           Console.WriteLine("----------------------");
           Console.WriteLine(firstName + ", "+ secondName + ", " + thirdName + ", " + fourthName);
        }
    }
}

