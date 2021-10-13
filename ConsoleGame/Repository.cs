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
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("H   H   A   N   N  GGGG M M M   A   N   N");
            Console.SetCursorPosition(20, 11);
            Console.WriteLine("H   H  A A  NN  N G     MM MM  A A  NN  N");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("HHHHH AAAAA N N N G  GG M M M AAAAA N N N");
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("H   H A   A N  NN G   G M   M A   A N  NN");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("H   H A   A N   N GGGG  M   M A   A N   N");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("Push a key to start.");
            Console.ReadKey();
        }

        public int getDifficulty()
        {
            bool validInput = false;
            int Difficulty;

            do
            {
                Console.WriteLine("Choose difficulty level:\n1) easy\n2) medium\n3) hard");
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
                Console.SetCursorPosition(10, 24);
                Console.Write("Select a letter out of the alphabet:");
                responseChar = Console.ReadKey().KeyChar;

                responseChar = char.ToUpper(responseChar);
                if (responseChar >= 'A' && responseChar <= 'Z')
                {
                    if (lettersUsed[(int)responseChar - 65] == false)
                    {
                        validInput = true;
                    }
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
                Console.SetCursorPosition(13, 3);
                Console.Write("XXXXXXX");
                Console.SetCursorPosition(12, 4);
                Console.Write("X  o o  X");
                Console.SetCursorPosition(12, 5);
                Console.Write("X   ^   X");
                Console.SetCursorPosition(12, 6);
                Console.Write("X  /-\\  X");
                Console.SetCursorPosition(13, 7);
                Console.Write("XXXXXXX");
            }

            if (bodyParts >= 2) // neck
            {
                Console.SetCursorPosition(15, 8);
                Console.Write("XXX");
                Console.SetCursorPosition(15, 9);
                Console.Write("XXX");
            }

            if (bodyParts >= 3) // torso
            {
                Console.SetCursorPosition(11, 10);
                Console.Write("XXXXXXXXXXX");
                Console.SetCursorPosition(11, 11);
                Console.Write("X         X");
                Console.SetCursorPosition(11, 12);
                Console.Write("X         X");
                Console.SetCursorPosition(11, 13);
                Console.Write("X         X");
                Console.SetCursorPosition(11, 14);
                Console.Write("X         X");
                Console.SetCursorPosition(11, 15);
                Console.Write("XXXXXXXXXXX");
            }

            if (bodyParts >= 4) // left arm
            {
                Console.SetCursorPosition(5, 7);
                Console.Write("XX");
                Console.SetCursorPosition(7, 8);
                Console.Write("XX");
                Console.SetCursorPosition(9, 9);
                Console.Write("XX");
            }

            if (bodyParts >= 5) // right arm
            {
                Console.SetCursorPosition(22, 9);
                Console.Write("XX");
                Console.SetCursorPosition(24, 8);
                Console.Write("XX");
                Console.SetCursorPosition(26, 7);
                Console.Write("XX");
            }
        
            if (bodyParts >= 6) // left leg
            {
                Console.SetCursorPosition(13, 16);
                Console.Write("XX");
                Console.SetCursorPosition(13, 17);
                Console.Write("XX");
                Console.SetCursorPosition(13, 18);
                Console.Write("XX");
                Console.SetCursorPosition(11, 19);
                Console.Write("XXXX");
            }

            if (bodyParts >= 7) // right leg
            {
                Console.SetCursorPosition(18, 16);
                Console.Write("XX");
                Console.SetCursorPosition(18, 17);
                Console.Write("XX");
                Console.SetCursorPosition(18, 18);
                Console.Write("XX");
                Console.SetCursorPosition(18, 19);
                Console.Write("XXXX");
            }
        } //DisplayHangman

        public void YouLose()
        {
            Console.SetCursorPosition(50, 5);
            Console.Write("Y   Y  OOO  U   U      L      OOO   SSSS EEEEE  !");
            Console.SetCursorPosition(50, 6);
            Console.Write(" Y Y  O   O U   U      L     O   O S     E      !");
            Console.SetCursorPosition(50, 7);
            Console.Write("  Y   O   O U   U      L     O   O  SSS  EEE    !");
            Console.SetCursorPosition(50, 8);
            Console.Write("  Y   O   O U   U      L     O   O     S E       ");
            Console.SetCursorPosition(50, 9);
            Console.Write("  Y    OOO   UUU       LLLLL  OOO  SSSS  EEEEE  !");
            Console.SetCursorPosition(50, 10);
            Console.Write("Press a key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public void YouWin()
        {
            Console.SetCursorPosition(50, 5);
            Console.Write("Y   Y  OOO  U   U      W   W IIIII N   N !");
            Console.SetCursorPosition(50, 6);
            Console.Write(" Y Y  O   O U   U      W   W   I   NN  N !");
            Console.SetCursorPosition(50, 7);
            Console.Write("  Y   O   O U   U      W W W   I   N N N !");
            Console.SetCursorPosition(50, 8);
            Console.Write("  Y   O   O U   U      WW WW   I   N  NN  ");
            Console.SetCursorPosition(50, 9);
            Console.Write("  Y    OOO   UUU       W   W IIIII N   N !"); 
            Console.SetCursorPosition(50, 10);
            Console.Write("Press a key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public void DisplayGuessed(string guessed)
        {
            Console.SetCursorPosition(40, 12);
            foreach (char x in guessed)
            {
                if (x == '\0')
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(x + " ");
                }
            }
        }

        public void DisplayLetters(bool[] lettersUsed)
        {
            Console.SetCursorPosition(10, 22);
            Console.Write("Letters Available");
            Console.SetCursorPosition(10, 23);
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
