using Design_Patterns_Assignment.Observer.ObserverFiles;
using Design_Patterns_Assignment.Observer.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class ObserverClass
    {
        internal static void Run()
        {
          
            MailBoxWatcher emailObserver = new MailBoxWatcher();
            Console.WriteLine("Observer");
            emailObserver.Update();

        }

    }
}


