using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //Check if no value at positon of array          
            if (numbers == null)
            {
                return 0;
            }

            var numEven = 0;
            var numOdd = 0;            
                  
            for (int i = 0; i < numbers.Length; i++)
            {
                  if (numbers[i] % 2 == 0)
                    {
                    numEven += numbers[i]; //store value of position to Evan 
                    }
                  else           
                    {
                    numOdd += numbers[i]; //store value position to Odd
                  }
            }            
           return numEven - numOdd;  //subtract the values           
       }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strList = new List<string>
            {
                str1,
                str2,
                str3,
                str4
            };

            int minLength = strList.Min(miLength => miLength.Length);
            
            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int>();
            numList.Add(number1);
            numList.Add(number2);
            numList.Add(number3);
            numList.Add(number4);

            int sNum = numList.Min();
            return sNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)

        {
            //biz is object name for Business with Name as property
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
          
            //looking for acute triangle  
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2)
            {
                return true;
            }
           else
            {
                return false;
            }
         

        }

        public bool IsStringANumber(string input)
        {
            // can use type decimal, double or float when trying to parse string 
            //to see if value can be converted to numeric
            // type int will not work because some numbers have a
            // decimal and will give a flase return
            var isNum = float.TryParse(input, out float num);

            return isNum;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //store length of each position in objs array to amount
            var amount = objs.Length;
            var majority = (amount / 2) + 1;

            var counter = 0;

            foreach(var item in objs)
            {
                if(item == null)
                {
                    counter++; // add 1 to counter for each null value in obj array
                }
            }
            if (counter >= majority) 
            {
                return true; 
            }
            else
            {
                return false;
            }

        }

        public double AverageEvens(int[] numbers)
        {
          var numEvens = 0;
            double counter = 0;
               
            if (numbers == null)
            {
              return 0;
            }
            

           foreach (var num in numbers)
           {

               
               if (num % 2 == 0)
               {
                    numEvens += num;
                    counter++;    
               }
           }

       
           if(counter > 0)
            {
                return numEvens / counter;
            }
           else
            {
                return 0;
            }
          

          
        }
        public int Factorial(int number)  // definition for Factorial found at https://www.cuemath.com/numbers/factorial/
        {
            var fact = 1;
           //factorial numbers with negative values or value of 0 are undefined
           // check if number is greater than 0
            if(number < 0)
            {
                //throw expection error for numbers <= 0
                throw new ArgumentOutOfRangeException();
            }
                    for( int i = number; i >0; i--)
                    {
                        fact *= i;
                    }             
                                          
                   return fact;           
        }
    }
}
