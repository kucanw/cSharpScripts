using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();
            int passwordLength = password.Length;
            int hasSymbols;
            bool hasUpperCaseLetters = false;
            

            //Handles upper case checking in password string
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]))
                {
                    hasUpperCaseLetters = true;
                }
            }
            if (!hasUpperCaseLetters)
            {
                Console.WriteLine("Your password doesn't contain uppercase letters");
            }

            //Checks for symbols in the password
            hasSymbols = password.IndexOf("*");
            if (hasSymbols == -1)
            {
                Console.WriteLine("Error! Your password has to include symbols");
            }           

            //Checks if the password is good
            if(hasSymbols >= 0 && hasUpperCaseLetters)
            {
                Console.WriteLine("Password is good");
            }
           
            Console.ReadLine();


        }
    }
}
