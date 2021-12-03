using Design_Patterns_Assignment.Strategy;
using Design_Patterns_Assignment.Strategy.Messages;
using System;

namespace Design_Patterns_Assignment
{
    internal class StrategyClass
    {


        public static void Run()
        {

            MessageHandler MessageHandler = new MessageHandler();        
            FaceBookMessage FaceBookMessage = new FaceBookMessage();
            Epost Epost = new Epost();
            Sms Sms = new Sms();

            Console.WriteLine("Strategy");
            var message = "This is the message";
   
            // Draw Menu
            Console.WriteLine("Welcome To MessageHandler");
            Console.WriteLine("---------------------");
            Console.WriteLine("  Select messagetyp to send   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("S: Sms");
            Console.WriteLine("F: Facebook Message");
            Console.WriteLine("E: Email");
            Console.WriteLine("X: Exit Program");

            //Main Game Loop
            while (true)
            {
                // Get User Input
                char userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 's' or 'S':

                        Console.Write("Using SMS");
                        MessageHandler.Message = Sms;
                        MessageHandler.SendMessage(message);
                        break;

                    case 'f' or 'F':

                        Console.Write("Using Facebook");
                        MessageHandler.Message = FaceBookMessage;
                        MessageHandler.SendMessage(message);
                        break;

                    case 'e' or 'E':

                        Console.Write("Using Email");
                        MessageHandler.Message = Epost;
                        MessageHandler.SendMessage(message);
                        break;

                    case 'x' or 'X':

                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:

                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }   
    }
}