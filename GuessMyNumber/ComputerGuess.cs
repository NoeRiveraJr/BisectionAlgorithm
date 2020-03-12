using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class ComputerGuess
    {
        public int humanNumber;
        public int computerGuess;
        public List<int> newList = new List<int>();
        public int length;
        public string checking;
        public bool foundGuess = false;
        public int numOfGuesses;

        public ComputerGuess()
        {
            for (int i = 1; i < 1001; i++)
            {
                this.newList.Add(i);
            }
            this.length = this.newList.Count;
            this.computerGuess = this.newList[this.length/2];
        }
        public void setHumanChoice(int humanChoice)
        {
            this.humanNumber = humanChoice;
        }
        public string findHumanChoice(int nextMove)
        {
            switch (nextMove)
            {
                case 1:
                    this.newList.RemoveRange(this.length / 2, this.length-(this.length/2));
                    this.length = this.newList.Count;
                    this.checking = ($"Greater than it is. Now checking the numbers: {this.newList[0]} - {this.newList[this.length-1]}\n");
                    this.computerGuess = this.newList[this.length / 2];
                    this.numOfGuesses++;
                    break;
                case 2:
                    this.newList.RemoveRange(0, this.length / 2);
                    this.length = this.newList.Count;
                    this.checking = ($"Less than it is. Now checking the numbers: {this.newList[0]} - {this.newList[this.length-1]}\n");
                    this.computerGuess = this.newList[this.length / 2];
                    this.numOfGuesses++;
                    break;
                case 3:
                    this.checking = ("That was too easy, could you give me a bigger challenge next time?\n");
                    this.foundGuess = true;
                    break;
            }
            return this.checking;
        }
    }
}
