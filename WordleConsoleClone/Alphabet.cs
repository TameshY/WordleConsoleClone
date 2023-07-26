using System;
namespace WordleConsoleClone
{
	public class Alphabet
	{
        public string builder(string word)
        {
            string char1, char2, char3, char4, char5;
            char[] letterArray = word.ToArray();
            char1 = letterArray[0].ToString();
            char2 = letterArray[1].ToString();
            char3 = letterArray[2].ToString();
            char4 = letterArray[3].ToString();
            char5 = letterArray[4].ToString();


            String returnStr = 
            "┌───┐ ┌───┐ ┌───┐ ┌───┐ ┌───┐\n" +
            "│ " + char1 + " │ │ " + char2 + " │ │ " + char3 + " │ │ " + char4 + " │ │ " + char5 + " │\n" +
            "└───┘ └───┘ └───┘ └───┘ └───┘";

            return returnStr;
        }


    }
}

