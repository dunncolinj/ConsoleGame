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

            // prompt user to select difficulty level
            Console.Clear();
            int Difficulty = myRepository.getDifficulty();

            // start game with appropriate difficulty level
            int bodyParts = 0;
            string word = myRepository.GetWord(Difficulty);
            string guessed = "";
            bool[] lettersUsed = new bool[26];
            bool gameWon = false;
            int replacements;

            for (int x=0; x<26; x++)
            {
                lettersUsed[x] = false;
            }

            foreach (char x in word)
            {
                guessed = guessed + "_";
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
                char letter = myRepository.getLetter();

                lettersUsed[(int)letter - 65] = true; // mark selected letter as used

                replacements = 0;
                for (int i=0; i<word.Length; i++)
                {
                    if (letter == word[i])
                    {
                        guessed[i] = letter;
                        replacements++;
                    }
                }

                if (guessed == word)
                {
                    // if all letters in word guessed, game ends and player wins
                    gameWon = true;
                }
                // if letter not in word, add one more body part
                if (replacements > 0)
                {
                    bodyParts++;
                }

                // if all body parts drawn (head, neck, left arm, right arm, torso, left leg, right leg) - game ends and player loses
                // this gets checked at the start of the loop
            } // main game loop

            // if out of the loop, determine if player won or lost
            if (bodyParts >= 7)
            {
                myRepository.YouLose();
            }
            else
            {
                myRepository.YouWin();
            }

            Console.ReadKey();
        } //
    } // UI class
} // namespace
