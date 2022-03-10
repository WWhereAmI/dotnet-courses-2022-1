using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class ContactInformation
    {
        private string phone;
        private string email;
        private string telegram;

        public string Phone 
        { 
            get => phone;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect phone");
                }
                phone = value;
            }
        }

        public string Email
        {
            get => email;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect email");
                }
                email = value;
            }
        }
        public string Telegram
        {
            get => telegram;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect telegram");
                }
                telegram = value;
            }
        }

        //Constructors
        public ContactInformation(string phone, string email, string telegram)
        {
            Phone = phone;
            Email = email;
            Telegram = telegram;
        }
        public ContactInformation(string phone, string email) : this(phone, email, "Телеграм не указан") { }
        public ContactInformation(string phone) : this(phone, "Почта не указана", "Телеграм не указан") { }
        public ContactInformation() : this("Телефон не указан", "Почта не указана", "Телеграм не указан") { }

        public override string ToString()
        {
            return $"{phone}:{email}:{telegram}";
        }

    }
}
