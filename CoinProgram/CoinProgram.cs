using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //A program in which a user enters an amount and gets the minimum number of coins that equal that value.
            // 1 gold = 10, 1 silver = 5, 1 bronze = 1

            Console.WriteLine("Please enter the coins ammount");
            int userCoins = Convert.ToInt16(Console.ReadLine());

            //If the number end with 0
            if ((userCoins % 10) == 0)
            {
                Console.WriteLine("You will get " + (userCoins / 10 + " gold coins"));
            }

            //If the number end with 5
            else if ((userCoins % 10) == 5)
            {
                Console.WriteLine("You will get " + (userCoins / 10) + " gold coins and 1 silver coin");
            }

            //If the number ends with 1-4
            else if ((userCoins % 10) < 5)
            {
                Console.WriteLine("You will get " + (userCoins / 10) + " gold coins and " + userCoins % 10 + " bronze coins");
            }

            //If the number ends with 6-9
            else if ((userCoins % 10) > 5)
            {
                Console.WriteLine("You will get " + userCoins / 10 + " gold coins, 1 silver coin and " + ((userCoins % 10) - 5) + " bronze coins");
            }
            Console.ReadLine();
        }
    }
}
