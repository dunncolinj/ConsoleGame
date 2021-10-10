using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    // define any enum types needed here

    class Repository
    {

        public List<string> _EasyWords
        {
            get
            {
                return _EasyWords;
            }
            set
            {
                
            }
        }

        public List<string> _MediumWords
        {
            get
            {
                return _MediumWords;
            }
            set
            {

            }
        }

        public List<string> _HardWords
        {
            get
            {
                return _HardWords;
            }
            set
            {

            }
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


        public char getLetter()
        {
            bool validInput = false;
            char response;
            do
            {
                Console.WriteLine("Select a letter out of the alphabet:");
                response = Console.ReadKey().KeyChar;
                if (response >= 'a' || response >= 'z')
                {
                    validInput = true;
                }
            }
            while (validInput == false);
            return response;
        }

        public string GetWord(int difficulty)
        {
            string word;
            int num;

            switch (difficulty)
            {
                case 1: num = Random.Next(_EasyWords.Count());
                    word = _EasyWords[num];
                    break;
                case 2: num = Random.Next(_MediumWords.Count());
                    word = _MediumWords[num];
                    break;
                case 3: num = Random.Next(_HardWords.Count());
                    word = _HardWords[num];
                    break;
                default: num = 0;
                    word = "";
                    break;
            }
            return word;
        }


        public void DisplayHangman(int bodyParts)
        {
            // display hanging apparatus
            // display body parts
        }
    } // class
} // namespace
