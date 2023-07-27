// See https://aka.ms/new-console-template for more information

using WordleConsoleClone;
using System.Collections.Generic;
using System.Linq;

Random rand = new Random();

int randWordIndex = rand.Next(1, 14856);

//Converts to array
string[] words = File.ReadAllLines(@"/Users/tamesh/Projects/WordleConsoleClone/WordleConsoleClone/valid-wordle-words.txt");


//Gets random word from wordle list
//string answer = words[randWordIndex];

//MANUAL ANSWER MODE
string answer = "aging";

char[] answerArray = answer.ToCharArray();

//Creates a list to hold the valid guesses
List<string> possibleGuesses = new List<string>();


//adds those guesses to the list
foreach (char letter in answerArray)
{
    possibleGuesses.Add(letter.ToString());
}

//holds the formatting method for strings
Alphabet stringFormatter = new Alphabet();

//Initial Display
Console.WriteLine("┌───┐ ┌───┐ ┌───┐ ┌───┐ ┌───┐");
Console.WriteLine("│   │ │   │ │   │ │   │ │   │");
Console.WriteLine("└───┘ └───┘ └───┘ └───┘ └───┘");

bool guessing = true;

int guesses = 6;

while (guessing == true) {
    Console.WriteLine("Enter a Guess: ");
    string? guess = Console.ReadLine();

    if (words.Contains(guess.ToLower()))
    {

        char[] guessLetterArray = guess.ToCharArray();

        string formattedGuess = stringFormatter.builder(guess);

        for (int index = 0; index < 5; index++)
        {
            if (answerArray.Contains(guessLetterArray[index]))
            {
                if (answerArray[index] == guessLetterArray[index])
                {
                    formattedGuess = stringFormatter.CorretAppend(formattedGuess, index);
                    possibleGuesses.Remove(guessLetterArray[index].ToString());
                }
                else if (answerArray.Contains(guessLetterArray[index]) && possibleGuesses.Contains(guessLetterArray[index].ToString()))
                {
                    formattedGuess = stringFormatter.AlmostCorretAppend(formattedGuess, index);
                }
            }
        }
        Console.WriteLine(formattedGuess);
        guesses -= 1;

        if (possibleGuesses.Count == 0)
        {
            Console.WriteLine("You got it! the word was: " + answer);
            Console.WriteLine("It took you a total of " + (6-guesses) + " guesses");
        }

        if (guesses <= 0)
        {
            Console.WriteLine("Try Again! You were so close.");
            Console.WriteLine("The word was: " + answer);
            guessing = false;
        }

    }
    else
    {
        Console.WriteLine("Not a word in the word list!");
    }
    
    
}

