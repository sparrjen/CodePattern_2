using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.ObserverFiles
{
    public class MailBoxWatcher : IMailBoxWatcher
    {
        
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
