using System;

namespace SentenciaIfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areYouAPerson = true;
            bool haveYouGotMoney = false;

            if (areYouAPerson && haveYouGotMoney)
            {
                Console.WriteLine("You can buy beer");
            }
            else
            {
                Console.WriteLine("You can't buy beer");
            }
        }
    }
}
