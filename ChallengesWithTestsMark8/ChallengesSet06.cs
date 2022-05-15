using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool boolWord = false;
            List<string> wordList = new List<string>();
            if(words == null || words.Contains(null))
            {
                 return false; 
            }
                       
            if(ignoreCase == true)
            {
                word = word.ToLower(); // make all letters in a word string lowercase

                wordList = words.Select(x => x.ToLower()).ToList();

                boolWord = wordList.Contains(word);                
            }
           
            
            if(ignoreCase == false)
            {
                boolWord = words.Contains(word);
            }
           
            return boolWord;

        }

        public bool IsPrimeNumber(int num)
        {
            var boolPrime = false;
            if(num > 0)
            {//start 1st if
                if (num % 2 != 0 && num % 3 != 0)
                {//start 2nd if                 
                    boolPrime = true;                
                } //end 2nd if
            }//end 1st if
           
            if (num == 2 || num == 3)
            { 
                boolPrime = true;
            }        

            if (num % 1 == num)
            {
                boolPrime = true;
            }

            if(num ==1 || num ==0)
            {
                boolPrime = false;
            }
            return boolPrime;
                   
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for(int i = 0; i < str.Length; i++)
            {
                uindex = true;
                for(int j = 0; j< str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }
                if(uindex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                int tempCount = 1;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    
                    if (numbers[i] != numbers[j])
                    {
                        break;  
                    }
                   tempCount++;
                }
                if (tempCount > count)
                {
                   count = tempCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] nullcheck = new double[0];
            if (elements == null )
            {
                return nullcheck;
            }
            List<double> getNinth = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    getNinth.Add(elements[i]);
                }
                if (n < 0 || n > elements.Count)
                {
                    getNinth.Clear();
                }
            }
            double[] resultsArray = getNinth.ToArray();

            return resultsArray;
        }
    }
}
