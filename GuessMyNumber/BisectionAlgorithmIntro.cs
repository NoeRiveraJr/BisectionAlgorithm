using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class BisectionAlgorithmIntro
    {
        public List<int> newList = new List<int>(); //fields are pretty similar throughout the classes used in this program
        public int length;                          //I should've implemented inheritance in my project to make my code more effective
        public string checking;                     //I will be creating a base class on GitHub in the future                                            
        public string newListPrint;
        public bool foundGuess = false;
        public int numOfGuesses;
        public BisectionAlgorithmIntro(int[] list) //constructor will convert the original array into a list since I can manipulate lists better
        {
            for(int i = 0; i < list.Length;i++)
            {
                this.newList.Add(list[i]);
            }
            this.length = this.newList.Count; //this.length is always assigned the new length of the list
        }

        public string getRanNumber(int guess) //the method itself is not recursive because I cannot find a way to print the newList to the screen
        {                                     //without using a Console.WriteLine outside of the program class
            string check = "";
            if (this.length % 2 == 0)   //this method will remove ranges off of the list with the use of the bisection algorithm
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

        public string printList() //this method creates a string that has all the values inside of the list
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
