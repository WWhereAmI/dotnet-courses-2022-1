namespace Task4
{
    internal class MyString
    {
        private char[] customString;

        //Constructors
        public MyString()
        {
            customString = new char[0];
        }

        public MyString(string str)
        {
            customString = new char[str.Length];

            FillArrayBy(str);
        }

        public MyString(char[] charArr)
        {
            customString = new char[charArr.Length];

            FillArrayBy(charArr);
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
                customString[i] = symbolsToFill[i];
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
                customString[i] = symbolsToFill[i];
            }
        }

        /// <summary>
        /// Adds new string to the end of the current string
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static MyString operator +(MyString str1, MyString str2)
        {
            char[] newString = new char[str1.customString.Length + str2.customString.Length];

            str1.customString.CopyTo(newString, 0);

            for (int i = str1.customString.Length, j = 0; i < newString.Length; i++, j++)
            {
                newString[i] = str2.customString[j];
            }

            return new MyString(newString);
        }

        /// <summary>
        /// Remove from the first input string, second input substring
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns>Modified first string</returns>
        public static MyString operator -(MyString str1, MyString str2)
        {
            string newstr1 = str1.ToString();
            string newstr2 = str2.ToString();

            if (newstr2.Length != 0)
            {
                newstr1 = newstr1.Replace(newstr2, string.Empty);
            }
  
            return new MyString(newstr1);
        }

        /// <summary>
        /// Determines whether two strings are same
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns>True if the value of str1 is the same as the value str2, otherwise false</returns>
        public static bool operator ==(MyString str1, MyString str2)
        {
            return str1?.ToString() == str2?.ToString();
        }

        /// <summary>
        /// Determines whether two strings are different
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns>False if the value of str1 is the same as the value str2, otherwise true</returns>
        public static bool operator !=(MyString str1, MyString str2)
        {
            return str1?.ToString() != str2?.ToString();
        }


        public override string ToString()
        {
            return new string(customString) ?? null;
        }

    }
}
