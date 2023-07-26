// See https://aka.ms/new-console-template for more information

using WordleConsoleClone;
using System.Collections.Generic;

Random rand = new Random();

int randWordIndex = rand.Next(1, 14856);

//Converts to array
string[] words = File.ReadAllLines(@"/Users/tamesh/Projects/WordleConsoleClone/WordleConsoleClone/valid-wordle-words.txt");


//Gets random word from wordle list
string answer = words[randWordIndex];
char[] answerArray = answer.ToCharArray();

//holds the formatting method for strings
Alphabet stringFormatter = new Alphabet();

//Initial Display
Console.WriteLine("┌───┐ ┌───┐ ┌───┐ ┌───┐ ┌───┐");
Console.WriteLine("│   │ │   │ │   │ │   │ │   │");
Console.WriteLine("└───┘ └───┘ └───┘ └───┘ └───┘");




bool guessing = true;

while (guessing == true) {
    Console.WriteLine("Enter a Guess: ");
    string? guess = Console.ReadLine();

    if (words.Contains(guess.ToLower()))
    {
        char[] guessLetterArray = guess.ToCharArray();
        foreach (char letter in guessLetterArray)
        {
            if(answerArray.Contains(letter))
            {

            }
        }
    }
    else
    {
        Console.WriteLine("Pick a different word");
    }
    //NEXT PRINT THE CHARCTER IN FACY FORMAT
}