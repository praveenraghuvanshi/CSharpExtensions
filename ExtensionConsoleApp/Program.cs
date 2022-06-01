using System;
using Extensions;

namespace ExtensionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ValidateZipcode();
        }

        private static void ValidateZipcode()
        {
            var validZipcode = "00158";
            if (validZipcode.IsValidZipCode())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{validZipcode} is an valid zipcode");
                Console.ForegroundColor = ConsoleColor.White;
            }

            var inValidZipcode = "0015";
            if (inValidZipcode.IsValidZipCode() == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{validZipcode} is an invalid zipcode");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
