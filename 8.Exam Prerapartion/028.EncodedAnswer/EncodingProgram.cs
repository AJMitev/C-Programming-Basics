using System;

    class EncodingProgram
    {
        static void Main(string[] args)
        {
            //Input
            uint n = uint.Parse(Console.ReadLine());
            uint answerAsNumber = 0;
            string encryptedAnswers = null;
            uint cntrA = 0;
            uint cntrB = 0;
            uint cntrC = 0;
            uint cntrD = 0;

            //Logic
            string encryptedLetter;
            for (int i = 0; i < n; i++)
            {
                answerAsNumber = uint.Parse(Console.ReadLine());
                if (answerAsNumber % 4 == 0)
                {
                    cntrA++;
                    encryptedLetter = "a ";
                    encryptedAnswers += encryptedLetter;
                }
                else if (answerAsNumber % 4 == 1)
                {
                    cntrB++;
                    encryptedLetter = "b ";
                    encryptedAnswers += encryptedLetter;
                }
                else if (answerAsNumber % 4 == 2)
                {
                    cntrC++;
                    encryptedLetter = "c ";
                    encryptedAnswers += encryptedLetter;
                }
                else if (answerAsNumber % 4 == 3)
                {
                    cntrD++;
                    encryptedLetter = "d ";
                    encryptedAnswers += encryptedLetter;
                }
            }

            //Output
            Console.WriteLine(encryptedAnswers);
            Console.WriteLine($"Answer A: {cntrA}");
            Console.WriteLine($"Answer B: {cntrB}");
            Console.WriteLine($"Answer C: {cntrC}");
            Console.WriteLine($"Answer D: {cntrD}");
        }


    }
