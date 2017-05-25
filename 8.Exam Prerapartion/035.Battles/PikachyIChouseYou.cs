using System;

class PikachyIChouseYou
{
    static void Main()
    {
        //Input
        int pokemonsOfPlayerOne = int.Parse(Console.ReadLine());
        int pokemonsOfPlayerTwo = int.Parse(Console.ReadLine());
        int maximumBattlesAllowed = int.Parse(Console.ReadLine());

        //Logic
        int currentBattle = 0;
        for (int i = 1; i <= pokemonsOfPlayerOne; i++)
        {
           
            for (int j = 1; j <= pokemonsOfPlayerTwo; j++)
            {
                currentBattle++;
               
                Console.Write($"({i} <-> {j}) ");
                if (currentBattle == maximumBattlesAllowed)
                {
                    return;
                }

            }

        }

    }
}

