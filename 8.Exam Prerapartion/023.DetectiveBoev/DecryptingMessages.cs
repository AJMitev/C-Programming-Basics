using System;
using System.Collections.Generic;


class DecryptingMessages
{
    static void Main(string[] args)
    {
        //Input
        
        string secretWord = Console.ReadLine();
        string encryptedMessage = Console.ReadLine();

        //Logic
        int mask = 0;
        for (int i = 0; i < secretWord.Length; i++)
        {
            int secretWordChar = secretWord[i];
            mask += secretWordChar;
        }
        //if (mask > 999) // 1001 => 1 + 0 + 0 + 1 = 2
        //{
        //    int thousands = mask / 1000;
        //    int hundreds = mask / 100;
        //    int lens = (mask % 100) / 10;
        //    int ones = mask % 10;

        //    mask = 0;
        //    mask = thousands + hundreds + lens + ones;
        //}
        if (mask > 99) // 101 => 1 + 0 + 1 = 2
        {
            int hundreds = mask / 100;
            int lens = (mask % 100) / 10;
            int ones = mask % 10;

            mask = 0;
            mask = hundreds + lens + ones;
        }
        if (mask > 9) // 11 => 1 + 1 = 2
        {
            int lens = (mask % 100) / 10;
            int ones = mask % 10;

            mask = 0;
            mask = lens + ones;
        }
        List<char> decryptedMessage = new List<char>();
        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            int decryptedLetter = encryptedMessage[i];
            if (decryptedLetter % mask == 0)
            {
                char decryptedChar = (char)(decryptedLetter + mask);             
                decryptedMessage.Add(decryptedChar);
            }
            else
            {
                char decryptedChar = (char)(decryptedLetter - mask);
                decryptedMessage.Add(decryptedChar);
            }
        }
        decryptedMessage.Reverse();

        //Output

        foreach (var decryptedChar in decryptedMessage)
        {
            Console.Write(decryptedChar);
        }
        Console.WriteLine();
    }
}

