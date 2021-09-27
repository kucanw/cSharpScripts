using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class PasswordChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();
            bool hasUpperCaseLetters = password.Any(char.IsUpper);
            bool hasSymbols = password.Any(ch => !Char.IsLetterOrDigit(ch));

            //Checks for upper case letters
            if (!hasUpperCaseLetters)
            {
                Console.WriteLine("Your password doesn't contain uppercase letters");
            }
            //Checks for symbols in the password
            if (!hasSymbols)
            {
                Console.WriteLine("Error! Your password has to include symbols");
            }           
            //Checks if the password is good
            if(hasSymbols && hasUpperCaseLetters)
            {
                Console.WriteLine("Password is good");
            }
            Console.ReadLine();
        }
    }
}
