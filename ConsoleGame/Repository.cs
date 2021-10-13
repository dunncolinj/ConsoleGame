using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    // define any enum types needed here

    public class Repository
    {
        public void TitleScreen()
        {
            Console.Clear();
            Console.WriteLine("Hangman");
            Console.WriteLine("Push a key to start");
            Console.ReadKey();
        }

        public int getDifficulty()
        {
            bool validInput = false;
            int Difficulty;

            do
            {
                Console.WriteLine("Choose difficulty level: 1) easy, 2) medium, 3) hard");
                char response = Console.ReadKey().KeyChar;
                if (response == '1' || response == '2' || response == '3')
                {
                    validInput = true;
                }

                switch (response)
                {
                    case '1': Difficulty = 1;
                        break;
                    case '2': Difficulty = 2;
                        break;
                    case '3': Difficulty = 3;
                        break;
                    default: Difficulty = 0;
                        break;
                }
            }
            while (validInput == false);

            return Difficulty;
        }


        public char getLetter(bool[] lettersUsed)
        {
            bool validInput = false;
            char responseChar = ' ';
            while (validInput == false)
            {
                Console.SetCursorPosition(50, 23);
                Console.Write("Select a letter out of the alphabet:");
                responseChar = Console.ReadKey().KeyChar;

                if ((lettersUsed[(int)responseChar - 65] == false) && (responseChar >= 'A' || responseChar >= 'Z'))
                {
                    validInput = true;
                }
            }
            return responseChar;
        }
        public void SeedWords(int Difficulty, List<string> Words)
        {
            
            switch (Difficulty)
            {
                case 1:
                    Words.Add("APPLAUSE");
                    Words.Add("BASKET");
                    Words.Add("CABIN");
                    Words.Add("FOOTPRINT");
                    Words.Add("TRANSPORTATION");
                    break;
                case 2:
                    Words.Add("AUDACIOUS");
                    Words.Add("COMMEMORATE");
                    Words.Add("ENIGMA");
                    Words.Add("FASTIDIOUS");
                    Words.Add("PANORAMA");
                    break;
                case 3:
                    Words.Add("ANOMALY");
                    Words.Add("EQUIVOCAL");
                    Words.Add("PRODIGAL");
                    Words.Add("DESSICATE");
                    Words.Add("VOLATILE");
                    break;
            }
        }
        public string GetWord(List<string> Words)
        {
            string word;
            int num;
            var rand = new Random();

            num = rand.Next(Words.Count());
                    word = Words[num];
            return word;
        }


        public void DisplayHangman(int bodyParts)
        {
            // display hanging apparatus

            Console.Clear();
            Console.WriteLine("|===============|");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine("|");
            }
            Console.WriteLine("|----------------");

            // display body parts

            if (bodyParts >= 1) // head
            {
                Console.SetCursorPosition(14, 4);
                Console.Write("XXXXXX");
                Console.SetCursorPosition(13, 5);
                Console.Write("X o o X");
                Console.SetCursorPosition(13, 6);
                Console.Write("X  ^  X");
                Console.SetCursorPosition(13, 7);
                Console.Write("X /-\\ X");
                Console.SetCursorPosition(14, 8);
                Console.Write("XXXXXX");
            }

            if (bodyParts >= 2) // neck
            {
                Console.SetCursorPosition(15, 9);
                Console.Write("XX");
                Console.SetCursorPosition(15, 10);
                Console.Write("XX");
            }

            if (bodyParts >= 3) // torso
            {
                Console.SetCursorPosition(11, 11);
                Console.Write("XXXXXXXXXXX");
                Console.SetCursorPosition(11, 12);
                Console.Write("X         X");
                Console.SetCursorPosition(11, 13);
                Console.Write("X         X");
                Console.SetCursorPosition(11, 14);
                Console.Write("X         X");
                Console.SetCursorPosition(11, 15);
                Console.Write("X         X");
                Console.SetCursorPosition(11, 16);
                Console.Write("XXXXXXXXXXX");
            }

            if (bodyParts >= 4) // left arm
            {
                Console.SetCursorPosition(5, 8);
                Console.Write("XX");
                Console.SetCursorPosition(7, 9);
                Console.Write("XX");
                Console.SetCursorPosition(9, 10);
                Console.Write("XX");
            }

            if (bodyParts >= 5) // right arm
            {
                Console.SetCursorPosition(23, 10);
                Console.Write("XX");
                Console.SetCursorPosition(25, 9);
                Console.Write("XX");
                Console.SetCursorPosition(27, 8);
                Console.Write("XX");
            }
        
            if (bodyParts >= 6) // left leg
            {
                Console.SetCursorPosition(13, 17);
                Console.Write("XX");
                Console.SetCursorPosition(13, 18);
                Console.Write("XX");
                Console.SetCursorPosition(13, 19);
                Console.Write("XX");
                Console.SetCursorPosition(11, 20);
                Console.Write("XXXX");
            }

            if (bodyParts >= 7) // right leg
            {
                Console.SetCursorPosition(18, 17);
                Console.Write("XX");
                Console.SetCursorPosition(18, 18);
                Console.Write("XX");
                Console.SetCursorPosition(18, 19);
                Console.Write("XX");
                Console.SetCursorPosition(18, 20);
                Console.Write("XXXX");
            }
        } //DisplayHangman

        public void YouLose()
        {
            Console.SetCursorPosition(50, 10);
            Console.Write("You lose!");
            Console.ReadKey();
        }

        public void YouWin()
        {
            Console.SetCursorPosition(50, 10);
            Console.Write("You win!");
            Console.ReadKey();

        }

        public void DisplayGuessed(string guessed)
        {
            Console.SetCursorPosition(40, 12);
            foreach (char x in guessed)
            {
                Console.Write(x + " ");
            }
        }

        public void DisplayLetters(bool[] lettersUsed)
        {
            Console.SetCursorPosition(14, 21);
            Console.Write("Letters Available");
            Console.SetCursorPosition(14, 22);
            for (int i=0; i<26; i++)
            {
                char letter = (char)(65 + i);
                if (lettersUsed[i] == false)
                {
                    Console.Write(letter + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
        }

    } // class
} // namespace
