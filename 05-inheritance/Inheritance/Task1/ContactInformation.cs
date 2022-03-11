using System;

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
                if (value == string.Empty)
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
                if (value == string.Empty)
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
                if (value == string.Empty)
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

        //null лучше заглушек
        public ContactInformation(string phone, string email) : this(phone, email, null) { }
        public ContactInformation(string phone) : this(phone, null, null) { }

        public override string ToString()
        {
            return $"{phone}:{email}:{telegram}";
        }

    }
}
