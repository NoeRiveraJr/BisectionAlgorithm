using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class BisectionAlgorithmIntro
    {
        public List<int> newList = new List<int>();
        public int length;
        public string checking;
        public string newListPrint;
        public bool foundGuess = false;
        public int numOfGuesses;
        public BisectionAlgorithmIntro(int[] list)
        {
            for(int i = 0; i < list.Length;i++)
            {
                this.newList.Add(list[i]);
            }
            this.length = this.newList.Count;
        }

        public string getRanNumber(int guess)
        {
            string check = "";
            if (this.length % 2 == 0)
            {
                if (this.newList[this.length/2-1]==guess)
                {
                    check = ($"The number you entered is {guess}.");
                    this.checking = check;
                    this.foundGuess = true;
                    this.numOfGuesses++;
                    printList();
                }
                else if(this.newList[this.length / 2 - 1] > guess)
                {
                    check = ($"The number you entered is less than {this.newList[this.length/2-1]}.");
                    this.checking = check;
                    this.newList.RemoveRange(this.length / 2 - 1, this.length - (this.length / 2 - 1));
                    this.length = this.newList.Count;
                    this.numOfGuesses++;
                    printList();
                }
                else
                {
                    check = ($"The number you entered is greater than {this.newList[this.length / 2 - 1]}.");
                    this.checking = check;
                    this.newList.RemoveRange(0, this.length/2);
                    this.length = this.newList.Count;
                    this.numOfGuesses++;
                    printList();
                }
            }
            else 
            {
                if (this.newList[this.length / 2] == guess)
                {
                    check = ($"The number you entered is {guess}.");
                    this.checking = check;
                    this.foundGuess = true;
                    this.numOfGuesses++;
                    printList();
                }
                else if (this.newList[this.length / 2] > guess)
                {
                    check = ($"The number you entered is less than {this.newList[this.length / 2]}.");
                    this.checking = check;
                    this.newList.RemoveRange(this.length / 2, this.length / 2+1);
                    this.length = this.newList.Count;
                    this.numOfGuesses++;
                    printList();
                }
                else
                {
                    check = ($"The number you entered is greater than {this.newList[this.length / 2]}.");
                    this.checking = check;
                    this.newList.RemoveRange(0, this.length / 2);
                    this.length = this.newList.Count;
                    this.numOfGuesses++;
                    printList();
                }
            }
            return this.checking;
        }

        public string printList()
        {
            string check ="";
            for(int i = 0; i < this.length;i++)
            {
                if(String.IsNullOrEmpty(check))
                {
                    check += ($"{this.newList[i]}");
                }
                else
                {
                    check += ($", {this.newList[i]}");
                }
            }
            this.newListPrint = check;
            return this.newListPrint;
        }

    }
}
