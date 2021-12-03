using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Strategy;
using System;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kan endast köra en i taget!! 

            DecoratorClass.Run();
            RepositoryClass.Run();
            StrategyClass.Run();
            ObserverClass.Run();

        }
    }
}