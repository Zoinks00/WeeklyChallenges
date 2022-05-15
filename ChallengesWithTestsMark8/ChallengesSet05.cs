using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if(startNumber == 0)
            {
                return n;
            }

            var numList = new List<int>();
            var numProd = startNumber * n; // store product of 2 numbers 
          
            for( int i =0; i < numProd; i++) //max amount of times to loop is = product of starting number
            {                                // * search number
               
                //check if value of i is greater than startNumber
                // and i can be evenly divided by search number
                if(i > startNumber && i % n ==0)
                {
                    numList.Add(i);
                }
            }

            return numList.First();

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i<businesses.Length; i++)
            {
                
                if(businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //return false if nothing in entry 
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (var i = 1; i < numbers.Length; i++)
            {
                //check if current array index is less than prevoius array index 
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }                              
            
            }//end for loop

             return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sumList = new List<int>();

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            for(var k = 1; k < numbers.Length; k++)
            {
                if (numbers[k - 1] % 2 == 0)
                {
                    sumList.Add(numbers[k]); 
                }
            }//end for loop

            return sumList.Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string sentence = "";
            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }

            if (sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
           

            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
             List<double> fourthElement = new List<double>();
            for(int k = 3; k < elements.Count; k += 4)
            {
                fourthElement.Add(elements[k]);
            }

            return fourthElement.ToArray();

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
           /* if (nums == null || nums.Length == 0)
            {
                return false;
            }*/

            //start 1st number at 1st index of the array
            for (int i = 0; i < nums.Length; i++)
            {//1st for loop
                //start 2nd number at 2nd index of array
                for (int j = i+1; j < nums.Length; j++)
                {//nested 2nd for loop
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }//end nested for
            }//end 1st for
            return false;
        }
    }
}
