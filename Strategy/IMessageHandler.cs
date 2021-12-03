using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    public interface IMessageHandler
    {
        public IMessage Message { get; set; }

        public void SendMessage(string message);
    }
}
