using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    internal class OldMyString
    {
        private char[] newString;

        /// <summary>
        /// Current capacity of the char array
        /// </summary>
        public int Capacity { get; private set; } = 25;

        /// <summary>
        /// Current count of the elements in the array
        /// </summary>
        public int Count { get => newString.Count(x => x != '\0'); }

        //Constructors
        public OldMyString()
        {
            newString = new char[Capacity];
        }

        public OldMyString(string str)
        {
            newString = new char[Capacity];

            while (Capacity < str.Length)
            {
                Resize(newString);
            }

            FillArrayBy(str);
        }

        public OldMyString(char[] charArr)
        {
            newString = new char[Capacity];

            while (Capacity < charArr.Length)
            {
                Resize(newString);
            }

            FillArrayBy(charArr);
        }

        /// <summary>
        /// Resize char array 
        /// </summary>
        /// <param name="oldString"></param>
        /// <returns>Char array with a bigger size</returns>
        private char[] Resize(char[] oldString)
        {
            Capacity *= 2;
            newString = new char[Capacity];

            FillArrayBy(oldString);

            return newString;
        }

        /// <summary>
        /// Fills the array with the second array 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="arr2"></param>
        private void FillArrayBy(char[] symbolsToFill)
        {
            for (int i = 0; i < symbolsToFill.Length; i++)
            {
                newString[i] = symbolsToFill[i];
            }
        }

        /// <summary>
        /// Fills the array with the second array 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="arr2"></param>
        private void FillArrayBy(string symbolsToFill)
        {
            for (int i = 0; i < symbolsToFill.Length; i++)
            {
                newString[i] = symbolsToFill[i];
            }
        }


        /// <summary>
        /// Adds new string to the end of the current string
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static OldMyString operator +(OldMyString str1, OldMyString str2)
        {
            char[] newString = new char[str1.newString.Length + str2.newString.Length];

            str1.newString.CopyTo(newString, 0);

            for (int i = str1.Count, j = 0; j < str2.Count; i++, j++)
            {
                newString[i] = str2.newString[j];
            }

            return new OldMyString(newString);
        }

        public static OldMyString operator -(OldMyString str1, OldMyString str2)
        {
            string newstr1 = str2.ToString();
            string newstr2 = str2.ToString();

            newstr1 = newstr1.Replace(newstr2, string.Empty);

            return new OldMyString(newstr1);
        }

        //public static bool operator ==(OldMyString str1, OldMyString str2)
        //{
        //    return str1.newString == str2.newString;
        //}

        //public static bool operator !=(OldMyString str1, OldMyString str2)
        //{
        //    return str1.newString != str2.newString;
        //}

        public override string ToString()
        {
            return new string(newString);
        }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

    }
}
