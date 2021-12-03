﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Design_Patterns_Assignment.Observer.SubjectFiles
{
    public interface IMailBox : ISubject
    {
        public void CreateTimer();

        public void HandleTimerElapsed(object sender, ElapsedEventArgs e);


    }
}
