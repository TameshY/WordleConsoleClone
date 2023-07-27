using System;
using System.Text;

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

        public string CorretAppend(string formattedText, int index)
        {
            char[] checkMark = "✔".ToCharArray();
            char[] charArray = formattedText.ToCharArray();
            switch (index)
            {
                case 0:
                    {
                        charArray[31] = checkMark[0];

                        charArray[33] = checkMark[0];

                        break;
                    }
                case 1:
                    {
                        charArray[37] = checkMark[0];

                        charArray[39] = checkMark[0];
                        break;
                        
                    }
                case 2:
                    {
                        charArray[43] = checkMark[0];

                        charArray[45] = checkMark[0];
                        break;
                    }
                case 3:
                    {
                        charArray[49] = checkMark[0];

                        charArray[51] = checkMark[0];
                        break;
                    }
                case 4:
                    {
                        charArray[55] = checkMark[0];

                        charArray[57] = checkMark[0];
                        break;
                    }
             
            }
            StringBuilder builder = new StringBuilder();

            foreach (char character in charArray)
            {
                builder.Append(character);
            }
            return builder.ToString();

            /**
             *  Indexes for boxes top 0-4, 6-10, 12-16, 18-22, 24-28
             *  
             *  Indexes for sidepeice 31-35, 37-41, 43-47, 49-53, 55-59
             *  
             *  Indexes for bottoms 62-66, 68-72, 74-78, 80-84, 86-90
             *  
             *  Letter Indexes 32, 39, 44, 56
             */
        }

        public string AlmostCorretAppend(string formattedText, int index)
        {
            char[] topBottomBorder = "?---?".ToCharArray();
         
            char[] charArray = formattedText.ToCharArray();
            switch (index)
            {
                case 0:
                    {
                        //Code for top
                        int count = 0;
                        for (int charIndex = 0; charIndex <= 5; charIndex++)
                        {
                            if (count < 5)
                            {
                                charArray[charIndex] = topBottomBorder[count];
                                count++;
                            }
                           
                        }

                        //Code for Bottom
                        count = 0;
                        for (int charIndex = 60; charIndex <= 64; charIndex++)
                        {
                            if (count < 5)
                            {
                                charArray[charIndex] = topBottomBorder[count];
                                count++;
                            }

                        }
                        break; 
                    }
                case 1:
                    {
                        //Code for top
                        int count = 0;
                        for (int charIndex = 6; charIndex <= 10; charIndex++)
                        {
                            if (count < 5)
                            {
                                charArray[charIndex] = topBottomBorder[count];
                                count++;
                            }

                        }

                        //Code for Bottom
                        count = 0;
                        for (int charIndex = 66; charIndex <= 71; charIndex++)
                        {
                            if (count < 5)
                            {
                                charArray[charIndex] = topBottomBorder[count];
                                count++;
                            }

                        }
                        break;

                    }
                case 2:
                    {
                        //Code for top
                        int count = 0;
                        for (int charIndex = 12; charIndex <= 17; charIndex++)
                        {
                            if (count < 5)
                            {
                                charArray[charIndex] = topBottomBorder[count];
                                count++;
                            }

                        }

                        //Code for Bottom
                        count = 0;
                        for (int charIndex = 72; charIndex <= 77; charIndex++)
                        {
                            if (count < 5)
                            {
                                charArray[charIndex] = topBottomBorder[count];
                                count++;
                            }

                        }
                        break;
                    }
                case 3:
                    {
                        //Code for top
                        int count = 0;
                        for (int charIndex = 18; charIndex <= 23; charIndex++)
                        {
                            if (count < 5)
                            {
                                charArray[charIndex] = topBottomBorder[count];
                                count++;
                            }

                        }

                        //Code for Bottom
                        count = 0;
                        for (int charIndex = 78; charIndex <= 83; charIndex++)
                        {
                            if (count < 5)
                            {
                                charArray[charIndex] = topBottomBorder[count];
                                count++;
                            }

                        }
                        break;
                    }
                case 4:
                    {
                        
                            //Code for top
                            int count = 0;
                            for (int charIndex = 24; charIndex <= 29; charIndex++)
                            {
                                if (count < 5)
                                {
                                    charArray[charIndex] = topBottomBorder[count];
                                    count++;
                                }

                            }

                            //Code for Bottom
                            count = 0;
                            for (int charIndex = 84; charIndex <= 89; charIndex++)
                            {
                                if (count < 5)
                                {
                                    charArray[charIndex] = topBottomBorder[count];
                                    count++;
                                }

                            }
                            break;
                    }

            }
            StringBuilder builder = new StringBuilder();

            foreach (char character in charArray)
            {
                builder.Append(character);
            }
            return builder.ToString();

            /**
             *  Indexes for boxes top 0-4, 6-10, 12-16, 18-22, 24-28
             *  
             *  Indexes for sidepeice 31-35, 37-41, 43-47, 49-53, 55-59
             *  
             *  Indexes for bottoms 62-66, 68-72, 74-78, 80-84, 86-90
             *  
             *  Letter Indexes 32, 39, 44, 56
             */
        }


    }
}

