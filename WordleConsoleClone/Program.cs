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

string answer = "apple";

char[] answerArray = answer.ToCharArray();


List<string> possibleGuesses = new List<string>();

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
    }
    else
    {
        Console.WriteLine("Not a word in the word list!");
    }
    
    
}

