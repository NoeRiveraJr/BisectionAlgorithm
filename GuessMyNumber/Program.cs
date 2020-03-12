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
            //int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            //BisectionAlgorithmIntro intro = new BisectionAlgorithmIntro(list);
            //string intro1 = ("Hi, it's me, your computer! This program will determine if you can guess a number faster than me!\n");
            //string intro2 = "To demonstrate how this is going to work, first, you will choose a number from 1 - 10, and you will see how many\ntries it takes for me to guess your number!";
            //printString(intro1);
            //printString(intro2);
            //Console.ReadKey();
            //Console.Clear();
            //string intro3 = "Please enter a number from 1 - 10: ";
            //printString(intro3);



            //int x;
            //string check = Console.ReadLine();
            //while (Int32.TryParse(check, out x) == false || x < 1 || x > 10)
            //{
            //    Console.Write("Please enter a valid number from 1 - 10: ");
            //    check = Console.ReadLine();
            //}
            //while (intro.foundGuess == false)
            //{
            //    intro.getRanNumber(x);
            //    printString(intro.checking);
            //    Console.Write("\n");
            //    if (intro.foundGuess == false)
            //    {
            //        printString($"Now checking the numbers: {intro.newListPrint}");
            //        Console.Write("\n");
            //    }
            //    else
            //    {
            //        printString($"The number of guesses it took me to find your number was: {intro.numOfGuesses}.\n");
            //        printString("Yaaaaawwwn! If I had feelings, I'd be bored! Lets make things more interesting.");
            //        intro.numOfGuesses = 0;
            //    }
            //}
            //Console.ReadKey();
            //Console.Clear();




            ////Beginning of the Human Trial protion of the program
            //string humanIntro = "Now you will face me to see who can guess a number faster!\nYou will be guessing a number that I choose from 1 - 1000.\n" +
            //    "You will be doing this 3 times to get an average number of guesses it takes for you to find my number!\n";
            //printString(humanIntro);
            //Console.ReadKey();
            //Console.Clear();

            //Random computerChoice = new Random();
            //int computerNumber = computerChoice.Next(1, 1001);
            //HumanGuess human = new HumanGuess(computerNumber);
            //string check2;
            //int y;
            //int sumOfHumanGuesses = 0;
            //int avgOfHumanGuesses = 0;

            //while (human.foundGuess == false)
            //{
            //    Console.Write($"Please enter guess from {human.newList[0]} - {human.newList[human.length-1]}: ");
            //    check2 = Console.ReadLine();
            //    while (Int32.TryParse(check2, out y) == false || y < (human.newList[0]) || y > (human.newList[human.length-1]))
            //    {
            //        Console.Write($"Please enter a valid number from {human.newList[0]} - {human.newList[human.length-1]}: ");
            //        check2 = Console.ReadLine();
            //    }
            //    y = Int32.Parse(check2);
            //    human.guessComputerChoice(y);
            //    printString(human.checking);
            //    Console.Write("\n");
            //    if(human.foundGuess==true)
            //    { 
            //        printString($"The number of guesses it took for you to guess my number is: {human.numOfGuesses}.\n");
            //        printString("Wow! That is not impressive at all. Ha, ha, ha!\n");
            //        sumOfHumanGuesses += human.numOfGuesses;
            //    }
            //}

            //printString("Lets see if you can do better on your second try!");
            //Console.ReadKey();
            //Console.Clear();
            //int computerNumber2 = computerChoice.Next(1, 1001);
            //HumanGuess human2 = new HumanGuess(computerNumber2);
            //while (human2.foundGuess == false)
            //{
            //    Console.Write($"Please enter guess from {human2.newList[0]} - {human2.newList[human2.length - 1]}: ");
            //    check2 = Console.ReadLine();
            //    while (Int32.TryParse(check2, out y) == false || y < (human2.newList[0]) || y > (human2.newList[human2.length - 1]))
            //    {
            //        Console.Write($"Please enter a valid number from {human2.newList[0]} - {human2.newList[human2.length - 1]}: ");
            //        check2 = Console.ReadLine();
            //    }
            //    y = Int32.Parse(check2);
            //    human2.guessComputerChoice(y);
            //    printString(human2.checking);
            //    Console.Write("\n");
            //    if (human2.foundGuess == true)
            //    {
            //        printString($"The number of guesses it took for you to guess my number is: {human2.numOfGuesses}.\n");
            //        printString("I am not worried about beating you!\n");
            //        sumOfHumanGuesses += human2.numOfGuesses;
            //    }
            //}

            //printString("I'm not worried, but I know that you are! You know what they say, 3rd times a charm!");
            //Console.ReadKey();
            //Console.Clear();
            //int computerNumber3 = computerChoice.Next(1, 1001);
            //HumanGuess human3 = new HumanGuess(computerNumber3);
            //while (human3.foundGuess == false)
            //{
            //    Console.Write($"Please enter guess from {human3.newList[0]} - {human3.newList[human3.length - 1]}: ");
            //    check2 = Console.ReadLine();
            //    while (Int32.TryParse(check2, out y) == false || y < (human3.newList[0]) || y > (human3.newList[human3.length - 1]))
            //    {
            //        Console.Write($"Please enter a valid number from {human3.newList[0]} - {human3.newList[human3.length - 1]}: ");
            //        check2 = Console.ReadLine();
            //    }
            //    y = Int32.Parse(check2);
            //    human3.guessComputerChoice(y);
            //    printString(human3.checking);
            //    Console.Write("\n");
            //    if (human3.foundGuess == true)
            //    {
            //        printString($"The number of guesses it took for you to guess my number is: {human3.numOfGuesses}.\n");
            //        printString("Wow friend! It looks like computers are going to win again! Lets calculate your average number of guesses!\n");
            //        sumOfHumanGuesses += human3.numOfGuesses;
            //    }
            //}
            //Console.ReadKey();
            //Console.Clear();
            //avgOfHumanGuesses = sumOfHumanGuesses / 3;
            //printString($"Your average number of guesses is..... {avgOfHumanGuesses}. A very unspectacular number friend!\n");



            //beginning of the computer trial portion
            printString("Now it is my turn to guess your number...I'm sure I'll beat you!\n");
            printString("Please enter a number from 1 - 1000 and I will try to guess your number! I have my eyes closed \nand I promise not to cheat friend.");
            string check3 = Console.ReadLine();
            int z;
            string checkCase;
            int caseSwitch;
            while (Int32.TryParse(check3, out z) == false || z <= 0 || z >= 1001)
            {
                Console.Write($"Please enter a valid number from 1 - 1000: ");
                check3 = Console.ReadLine();
            }
            Console.ReadKey();
            Console.Clear();
            ComputerGuess computer = new ComputerGuess();
            computer.setHumanChoice(z);
            while (computer.foundGuess == false)
            {
                Console.WriteLine($"My guess is {computer.computerGuess}. Please tell me whether my guess is greater than your number, less than your number, or is your number.");
                Console.Write("1. Greater than your number.\n2. Less than your number\n3. This is your number! :)\n");
                checkCase = Console.ReadLine();
                while (Int32.TryParse(checkCase, out caseSwitch) == false || caseSwitch <= 0 || caseSwitch >= 4 )
                {
                    Console.Write("Please enter a valid menu option(Number 1, 2, or 3): ");
                    checkCase = Console.ReadLine();
                }
                switch(caseSwitch)
                {
                    case 1:
                        if (computer.newList[computer.length / 2] <= computer.humanNumber)
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
                        if(computer.newList[computer.length/2] != computer.humanNumber)
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
                    //sumOfHumanGuesses += human.numOfGuesses;
                }
            }
        }
        public static void printString(string y)
        {
            for(int i =0; i < y.Length;i++)
            {
                Console.Write(y[i]);
                System.Threading.Thread.Sleep(35);
            }
        }
    }
}
