using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class OfficeEventArgs : EventArgs
    {
        private DateTime dateTime;

        public string Name { get; }
        public string Message { get; private set; }

        public DateTime DateTime 
        { 
            get => dateTime; 
            private set
            {
                if (value.Hour > 6 && value.Hour < 12)
                {
                    Message = "Доброе утро";
                    
                }
                else if (value.Hour > 12 && value.Hour < 17)
                {
                    Message = "Добрый день";
                }
                else
                {
                    Message = "Добрый вечер";
                }

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
