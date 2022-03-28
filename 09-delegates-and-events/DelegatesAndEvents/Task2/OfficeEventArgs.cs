using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class OfficeEventArgs : EventArgs
    {
        private DateTime dateTime;

        public string Name { get; }

        public DateTime DateTime 
        { 
            get => dateTime; 
            private set
            {
             
                dateTime = value;
            }
        }

        public OfficeEventArgs(DateTime dateTime, string employeeName)
        {
            DateTime = dateTime;
            Name = employeeName;
        }


    }
}
