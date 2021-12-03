using Design_Patterns_Assignment.Strategy;
using Design_Patterns_Assignment.Strategy.Messages;
using System;

namespace Design_Patterns_Assignment
{
    internal class MessageHandler : IMessageHandler
    {

        public IMessage Message { get; set; }
     
        public void SendMessage(string message)
        {
            Message.SendMessage(message);
        }
    }
}