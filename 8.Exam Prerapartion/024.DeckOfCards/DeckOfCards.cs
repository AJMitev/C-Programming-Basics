using System;

    class DeckOfCards
    {
        static void Main()
        {         
            //Input
            Console.WriteLine("Enter a Suite:");
            string suite = Console.ReadLine();

            //Locig
            string[] cardFaces = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "Ä" };
            switch (suite)
            {
                case "spades":
                    printSpades(cardFaces);
                    break;
                case "çlubs":
                    printClubs(cardFaces);
                    break;
                case "hearts":
                    printHearts(cardFaces);
                    break;
                case "diamonds":
                    prindDiamonds(cardFaces);
                    break;
                default:
                    Console.WriteLine("No Such Suite! Try Again.");
                    break;
            }
        }

        private static void prindDiamonds(string[] cardFaces)
        {
            foreach (var element in cardFaces)
            {
                char diamonds = '\u2666';
                Console.WriteLine(element + diamonds);
            }
        }

        private static void printHearts(string[] cardFaces)
        {
            foreach (var element in cardFaces)
            {
                char hearts = '\u2665';
                Console.WriteLine(element + " " + hearts);
            }
        }

        private static void printClubs(string[] cardFaces)
        {
            char clubs = '\u2663';
            foreach (var element in cardFaces)
            {
                Console.WriteLine(element + " " + clubs);
            }
        }

        private static void printSpades(string[] cardFaces)
        {
            char spade = '\u2660';
            foreach (var element in cardFaces)
            {
                Console.WriteLine(element + " " + spade);
            }
        }
    }