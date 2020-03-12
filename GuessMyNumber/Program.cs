using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };  //first portion of the program creates an array from 1 - 10. Shows how the computer iterates through a set of numbers
            BisectionAlgorithmIntro intro = new BisectionAlgorithmIntro(list);
            string intro1 = ("Hi, it's me, your computer! This program will determine if you can guess a number faster than me!\n");
            string intro2 = "To demonstrate how this is going to work, first, you will choose a number from 1 - 10, and you will see how many\ntries it takes for me to guess your number!";
            printString(intro1);  //calls the printString method that I created to simulate the computer typing to you.
            printString(intro2);
            Console.ReadKey();
            Console.Clear();
            string intro3 = "Please enter a number from 1 - 10: ";
            printString(intro3);



            int x;
            string check = Console.ReadLine();
            while (Int32.TryParse(check, out x) == false || x < 1 || x > 10)    //data validation 
            {
                Console.Write("Please enter a valid number from 1 - 10: ");
                check = Console.ReadLine();
            }
            while (intro.foundGuess == false)  //foundGuess is a field in all my classes that is used to create recursion with a while loop.
            {
                intro.getRanNumber(x);
                printString(intro.checking);
                Console.Write("\n");
                if (intro.foundGuess == false)
                {
                    printString($"Now checking the numbers: {intro.newListPrint}");
                    Console.Write("\n");
                }
                else
                {
                    printString($"The number of guesses it took me to find your number was: {intro.numOfGuesses}.\n");
                    printString("Yaaaaawwwn! If I had feelings, I'd be bored! Lets make things more interesting.");  //the computer is supposed to be funny and sarcastic
                    intro.numOfGuesses = 0;
                }
            }
            Console.ReadKey();
            Console.Clear();




            //Beginning of the Human Trial protion of the program, this trial is ran 3 times to get an average of human guesses
            string humanIntro = "Now you will face me to see who can guess a number faster!\nYou will be guessing a number that I choose from 1 - 1000.\n" +
                "You will be doing this 3 times to get an average number of guesses it takes for you to find my number!\n";
            printString(humanIntro);
            Console.ReadKey();
            Console.Clear();

            Random computerChoice = new Random();     //the computer will select a random number from 1 - 100, the user gets to guess that number
            int computerNumber = computerChoice.Next(1, 1001);
            HumanGuess human = new HumanGuess(computerNumber);
            string check2;
            int y;
            int sumOfHumanGuesses = 0;
            int avgOfHumanGuesses = 0;

            while (human.foundGuess == false)
            {
                Console.Write($"Please enter guess from {human.newList[0]} - {human.newList[human.length - 1]}: ");
                check2 = Console.ReadLine();       //the list keeps getting shorter as the user guesses a number, thus the data validation needs to change values as program iterates through
                while (Int32.TryParse(check2, out y) == false || y < (human.newList[0]) || y > (human.newList[human.length - 1]))
                {
                    Console.Write($"Please enter a valid number from {human.newList[0]} - {human.newList[human.length - 1]}: ");
                    check2 = Console.ReadLine();
                }
                y = Int32.Parse(check2);
                human.guessComputerChoice(y);
                printString(human.checking);
                Console.Write("\n");
                if (human.foundGuess == true)
                {
                    printString($"The number of guesses it took for you to guess my number is: {human.numOfGuesses}.\n");
                    printString("Wow! That is not impressive at all. Ha, ha, ha!\n");
                    sumOfHumanGuesses += human.numOfGuesses;
                }
            }

            printString("Lets see if you can do better on your second try!");
            Console.ReadKey();
            Console.Clear();
            int computerNumber2 = computerChoice.Next(1, 1001);
            HumanGuess human2 = new HumanGuess(computerNumber2);
            while (human2.foundGuess == false)
            {
                Console.Write($"Please enter guess from {human2.newList[0]} - {human2.newList[human2.length - 1]}: ");
                check2 = Console.ReadLine();
                while (Int32.TryParse(check2, out y) == false || y < (human2.newList[0]) || y > (human2.newList[human2.length - 1]))
                {
                    Console.Write($"Please enter a valid number from {human2.newList[0]} - {human2.newList[human2.length - 1]}: ");
                    check2 = Console.ReadLine();
                }
                y = Int32.Parse(check2);
                human2.guessComputerChoice(y);
                printString(human2.checking);
                Console.Write("\n");
                if (human2.foundGuess == true)
                {
                    printString($"The number of guesses it took for you to guess my number is: {human2.numOfGuesses}.\n");
                    printString("I am not worried about beating you!\n");
                    sumOfHumanGuesses += human2.numOfGuesses;
                }
            }

            printString("I'm not worried, but I know that you are! You know what they say, 3rd times a charm!");
            Console.ReadKey();
            Console.Clear();
            int computerNumber3 = computerChoice.Next(1, 1001);
            HumanGuess human3 = new HumanGuess(computerNumber3);
            while (human3.foundGuess == false)
            {
                Console.Write($"Please enter guess from {human3.newList[0]} - {human3.newList[human3.length - 1]}: ");
                check2 = Console.ReadLine();
                while (Int32.TryParse(check2, out y) == false || y < (human3.newList[0]) || y > (human3.newList[human3.length - 1]))
                {
                    Console.Write($"Please enter a valid number from {human3.newList[0]} - {human3.newList[human3.length - 1]}: ");
                    check2 = Console.ReadLine();
                }
                y = Int32.Parse(check2);
                human3.guessComputerChoice(y);
                printString(human3.checking);
                Console.Write("\n");
                if (human3.foundGuess == true)
                {
                    printString($"The number of guesses it took for you to guess my number is: {human3.numOfGuesses}.\n");
                    printString("Wow friend! It looks like computers are going to win again! Lets calculate your average number of guesses!\n");
                    sumOfHumanGuesses += human3.numOfGuesses;
                }
            }
            Console.ReadKey();
            Console.Clear();
            avgOfHumanGuesses = sumOfHumanGuesses / 3;  //this portion calculates the average for the number of guesses it took the user to find answer
            printString($"Your average number of guesses is..... {avgOfHumanGuesses}. A very unspectacular number friend!\n");



            //beginning of the computer trial portion, once again, it will be conducted 3 times to get an average
            printString("Now it is my turn to guess your number...I'm sure I'll beat you!\n");
            printString("Please enter a number from 1 - 1000 and I will try to guess your number! I have my eyes closed \nand I promise not to cheat friend.");
            string check3 = Console.ReadLine();
            int z;
            string checkCase;
            int caseSwitch;
            int sumOfComputerGuesses = 0;
            int avgOfComputerGuesses = 0;
            while (Int32.TryParse(check3, out z) == false || z <= 0 || z >= 1001)  //user inputs a validated number from 1 - 1000 to begin
            {
                Console.Write($"Please enter a valid number from 1 - 1000: ");
                check3 = Console.ReadLine();
            }
            Console.ReadKey();
            Console.Clear();
            ComputerGuess computer = new ComputerGuess();
            computer.setHumanChoice(z);
            while (computer.foundGuess == false)
            {                     //user needs to tell program that the programs guess is greater than, less than, or equal to the programs guess
                Console.WriteLine($"My guess is {computer.computerGuess}. Please tell me whether my guess is greater than your number, less than your number, or is your number.");
                Console.Write("1. Greater than your number.\n2. Less than your number\n3. This is your number! :)\n");
                checkCase = Console.ReadLine();
                while (Int32.TryParse(checkCase, out caseSwitch) == false || caseSwitch <= 0 || caseSwitch >= 4)
                {
                    Console.Write("Please enter a valid menu option(Number 1, 2, or 3): ");
                    checkCase = Console.ReadLine();
                }
                switch (caseSwitch)
                {
                    case 1:
                        if (computer.newList[computer.length / 2] <= computer.humanNumber)  //every case validates that the user did not lie 
                        {
                            Console.Clear();
                            printString("Unlike humans, computers cannot lie...Something tells me you made the wrong choice! Lets try again!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            computer.findHumanChoice(1);
                            printString(computer.checking);
                            break;
                        }
                    case 2:
                        if (computer.newList[computer.length / 2] >= computer.humanNumber)
                        {
                            Console.Clear();
                            printString("Unlike humans, computers cannot lie...Something tells me you made the wrong choice! Lets try again!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            computer.findHumanChoice(2);
                            printString(computer.checking);
                            break;
                        }
                    case 3:
                        if (computer.newList[computer.length / 2] != computer.humanNumber)
                        {
                            Console.Clear();
                            printString("Unlike humans, computers cannot lie...Something tells me you made the wrong choice! Lets try again!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            computer.findHumanChoice(3);
                            printString(computer.checking);
                            break;
                        }
                }
                if (computer.foundGuess == true)
                {
                    printString($"The number of guesses it took for me to guess your number is: {computer.numOfGuesses}.\n");
                    printString("Wow! That is impressive. I always suprise myself!\n");
                    sumOfComputerGuesses += computer.numOfGuesses;
                }
            }
            Console.ReadKey();
            Console.Clear();


            printString("Let's try that a second time to see if I could do better...I already know I'm doing better than you!\n");
            printString("Please enter a number from 1 - 1000 and I will try to guess your number! I have my eyes closed \nand I promise not to cheat friend.");
            string check4 = Console.ReadLine();
            int xX;
            string checkCase2;
            int caseSwitch2;
            while (Int32.TryParse(check4, out xX) == false || xX <= 0 || xX >= 1001)
            {
                Console.Write($"Please enter a valid number from 1 - 1000: ");
                check4 = Console.ReadLine();
            }
            Console.ReadKey();
            Console.Clear();
            ComputerGuess computer2 = new ComputerGuess();
            computer2.setHumanChoice(xX);
            while (computer2.foundGuess == false)
            {
                Console.WriteLine($"My guess is {computer2.computerGuess}. Please tell me whether my guess is greater than your number, less than your number, or is your number.");
                Console.Write("1. Greater than your number.\n2. Less than your number\n3. This is your number! :)\n");
                checkCase2 = Console.ReadLine();
                while (Int32.TryParse(checkCase2, out caseSwitch2) == false || caseSwitch2 <= 0 || caseSwitch2 >= 4)
                {
                    Console.Write("Please enter a valid menu option(Number 1, 2, or 3): ");
                    checkCase2 = Console.ReadLine();
                }
                switch (caseSwitch2)
                {
                    case 1:
                        if (computer2.newList[computer2.length / 2] <= computer2.humanNumber)
                        {
                            Console.Clear();
                            printString("Unlike humans, computers cannot lie...Something tells me you made the wrong choice! Lets try again!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            computer2.findHumanChoice(1);
                            printString(computer2.checking);
                            break;
                        }
                    case 2:
                        if (computer2.newList[computer2.length / 2] >= computer2.humanNumber)
                        {
                            Console.Clear();
                            printString("Unlike humans, computers cannot lie...Something tells me you made the wrong choice! Lets try again!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            computer2.findHumanChoice(2);
                            printString(computer2.checking);
                            break;
                        }
                    case 3:
                        if (computer2.newList[computer2.length / 2] != computer2.humanNumber)
                        {
                            Console.Clear();
                            printString("Unlike humans, computers cannot lie...Something tells me you made the wrong choice! Lets try again!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            if(computer.numOfGuesses==0)
                            {
                                computer.numOfGuesses++;
                            }
                            computer2.findHumanChoice(3);
                            printString(computer2.checking);
                            break;
                        }
                }
                if (computer2.foundGuess == true)
                {
                    printString($"The number of guesses it took for me to guess your number is: {computer2.numOfGuesses}.\n");
                    printString("Computers will always beat humans!\n");
                    sumOfComputerGuesses += computer2.numOfGuesses;
                }
            }
            Console.ReadKey();
            Console.Clear();

            //last computer guess
            printString("Let's try that one last time and compare our results to one another!\n");
            printString("Please enter a number from 1 - 1000 and I will try to guess your number! I have my eyes closed \nand I promise not to cheat friend.");
            string check5 = Console.ReadLine();
            int yY;
            string checkCase3;
            int caseSwitch3;
            while (Int32.TryParse(check5, out yY) == false || yY <= 0 || yY >= 1001)
            {
                Console.Write($"Please enter a valid number from 1 - 1000: ");
                check5 = Console.ReadLine();
            }
            Console.ReadKey();
            Console.Clear();
            ComputerGuess computer3 = new ComputerGuess();
            computer3.setHumanChoice(yY);
            while (computer3.foundGuess == false)
            {
                Console.WriteLine($"My guess is {computer3.computerGuess}. Please tell me whether my guess is greater than your number, less than your number, or is your number.");
                Console.Write("1. Greater than your number.\n2. Less than your number\n3. This is your number! :)\n");
                checkCase3 = Console.ReadLine();
                while (Int32.TryParse(checkCase3, out caseSwitch3) == false || caseSwitch3 <= 0 || caseSwitch3 >= 4)
                {
                    Console.Write("Please enter a valid menu option(Number 1, 2, or 3): ");
                    checkCase3 = Console.ReadLine();
                }
                switch (caseSwitch3)
                {
                    case 1:
                        if (computer3.newList[computer3.length / 2] <= computer3.humanNumber)
                        {
                            Console.Clear();
                            printString("Unlike humans, computers cannot lie...Something tells me you made the wrong choice! Lets try again!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            computer3.findHumanChoice(1);
                            printString(computer3.checking);
                            break;
                        }
                    case 2:
                        if (computer3.newList[computer3.length / 2] >= computer3.humanNumber)
                        {
                            Console.Clear();
                            printString("Unlike humans, computers cannot lie...Something tells me you made the wrong choice! Lets try again!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            computer3.findHumanChoice(2);
                            printString(computer3.checking);
                            break;
                        }
                    case 3:
                        if (computer3.newList[computer3.length / 2] != computer3.humanNumber)
                        {
                            Console.Clear();
                            printString("Unlike humans, computers cannot lie...Something tells me you made the wrong choice! Lets try again!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            computer3.findHumanChoice(3);
                            printString(computer3.checking);
                            break;
                        }
                }
                if (computer3.foundGuess == true)
                {
                    printString($"The number of guesses it took for me to guess your number is: {computer3.numOfGuesses}.\n");
                    printString("This was toooooo easy!\n");
                    sumOfComputerGuesses += computer3.numOfGuesses;
                }
            }
            Console.ReadKey();
            Console.Clear();

            avgOfComputerGuesses = sumOfComputerGuesses / 3;    //last portion of the program, both averages are compared and the final results are displayed to the user
            printString($"Let's check the results of this guessing game!\n");
            printString($"Your average number of guesses to find my number was: {avgOfHumanGuesses}.\n");
            printString($"My average number of guesses to find your number was: {avgOfComputerGuesses}.\n");
            if(avgOfComputerGuesses<avgOfHumanGuesses)
            {
                printString("I was never worried throughout this competition friend. The method I used\nto beat you is called the Bisection Algorithm! Do some research on my internet browser!");
            }
            else if(avgOfComputerGuesses>avgOfHumanGuesses)
            {
                printString("You've won! You must be really lucky or used the Bisection Algorithm. Do some research on my internet browser about it!");
            }
            else
            {
                printString("It seems like we are equally as intelligent! We both utilized the Bisection Algorithm effectively!\nDo some research on my internet browser about it!");
            }
            Console.ReadKey();
            Console.Clear();


        }

        public static void printString(string y) //neat method created to simulate the computer comunicating with the user
        {
            for(int i =0; i < y.Length;i++)
            {
                Console.Write(y[i]);
                System.Threading.Thread.Sleep(35);
            }
        }
    }
}
