using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class HumanGuess
    {
        public int computerNumber;
        public List<int> newList = new List<int>();
        public int length;
        public string checking;
        public bool foundGuess = false;
        public int numOfGuesses;

        public HumanGuess(int computerChoice) //constructor populates the numbers 1 - 1000 into the list
        {
            this.computerNumber = computerChoice;
            for(int i = 1; i < 1001;i++)
            {
                this.newList.Add(i);
            }
            this.length = this.newList.Count;
        }

        public string guessComputerChoice(int guess)  //this method removes a range of numbers depending on whether the user's guess is greater than or less than the randomly generated program choice of number
        {
            string check = "";
            if (guess == this.computerNumber)
            {
                check = ($"You have guessed my number, {this.computerNumber}, correctly.");
                this.checking = check;
                this.foundGuess = true;
                this.numOfGuesses++;

            }
            else if (guess > this.computerNumber)
            {
                check = ($"Your guess, {guess}, is greater than the number I chose. Try again!");
                this.checking = check;
                this.newList.RemoveRange(this.newList.FindIndex(x=> x==guess),this.length-this.newList.FindIndex(x => x == guess));
                this.length = this.newList.Count;
                this.numOfGuesses++;

            }
            else
            {
                check = ($"Your guess, {guess}, is less than the number I chose. Try again!");
                this.checking = check;
                this.newList.RemoveRange(0, this.newList.FindIndex(x => x == guess));
                this.length = this.newList.Count;
                this.numOfGuesses++;

            }
            return this.checking;
        }
    }
}
