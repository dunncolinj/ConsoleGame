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
            // display "Hangman" title screen

            // prompt user to select difficulty level
            Console.Clear();
            int Difficulty = getDifficulty();

            // start game with appropriate difficulty level
            int bodyParts = 0;
            string word = GetWord(Difficulty);
            bool[] charguessed = new bool[word.Length];
            bool[] letterused = new bool[26];


            // main game loop
            while (bodyParts < 7 )
            {
                Console.Clear();
                DisplayHangman(bodyParts);

                // display word to guess with letters blanked out

                // display letters not already guessed

                // get letter from user
                char letter = getLetter();

                // if all letters in word guessed, game ends and player wins

                // if letter not in word, add one more body part

                // if all body parts drawn (head, neck, left arm, right arm, torso, left leg, right leg) - game ends and player loses


            }










        }



    }
}
