using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class UI
    {
        // class for user interface

        public void Game()
        {
            Repository myRepository = new Repository();

            // display "Hangman" title screen
            myRepository.TitleScreen();

            // prompt user to select difficulty level
            Console.Clear();
            int Difficulty = myRepository.getDifficulty();

            List<string> Words = new List<string>();

            myRepository.SeedWords(Difficulty, Words);

            // start game with appropriate difficulty level
            int bodyParts = 0;
            string word = myRepository.GetWord(Words);
            string guessed = "";
            bool[] lettersUsed = new bool[26];
            bool gameWon = false;
            int replacements;
            char[] replaced = new char[word.Length];

            for (int x=0; x<26; x++)
            {
                lettersUsed[x] = false;
            }

            foreach (char x in word)
            {
                guessed = guessed + "-";
            }

            // main game loop
            while (bodyParts < 7 && gameWon == false)
            {
                Console.Clear();
                myRepository.DisplayHangman(bodyParts);

                // display word to guess with letters blanked out
                myRepository.DisplayGuessed(guessed);

                // display letters not already guessed
                myRepository.DisplayLetters(lettersUsed);

                // get letter from user
                char letter = myRepository.getLetter(lettersUsed);

                lettersUsed[(int)letter - 65] = true; // mark selected letter as used

                replacements = 0;

                for (int i=0; i<word.Length; i++)
                {
                    if (letter == word[i])
                    {
                        replaced[i] = letter;
                        replacements++;
                    }
                }

                guessed = new string(replaced);

                if (guessed == word)
                {
                    // if all letters in word guessed, game ends and player wins
                    gameWon = true;
                }
                // if letter not in word, add one more body part
                if (replacements == 0)
                {
                    bodyParts++;
                }

                // if all body parts drawn (head, neck, torso, left arm, right arm, left leg, right leg) - game ends and player loses
                // this gets checked at the start of the loop
            } // main game loop

            // if out of the loop, determine if player won or lost
            if (bodyParts >= 7)
            {
                myRepository.DisplayHangman(bodyParts);
                myRepository.YouLose();
            }
            else
            {
                myRepository.DisplayGuessed(guessed);
                myRepository.YouWin();
            }

        } // Game method
    } // UI class
} // namespace
