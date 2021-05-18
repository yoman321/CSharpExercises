using System;

namespace _3._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNbre = new Random();
            int card = randomNbre.Next(0, 14);
            int suit = randomNbre.Next(4);
            String cardNbre = "";
            String cardSuit = "";

            if (card > 10)
            {
                switch(card)
                {
                    case 11: cardNbre = "Jack"; break;
                    case 12: cardNbre = "Queen"; break;
                    case 13: cardNbre = "King"; break;
                }
            }
            else
            {
                cardNbre = Convert.ToString(card);
            }
            switch(suit)
            {
                case 0: cardSuit = "Spaes"; break;
                case 1: cardSuit = "Hearts"; break;
                case 2: cardSuit = "Diamonds"; break;
                case 3: cardSuit = "Clubs"; break;
            }
            Console.WriteLine($"The card you picked is {cardNbre} of {cardSuit}");
        }
    }
}
