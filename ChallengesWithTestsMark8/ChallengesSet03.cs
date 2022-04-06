using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach( var item in vals)
            {
                if(item == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var oddSum = numbers.Sum();

            return (oddSum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isLower = false;
            bool isUpper = false;
            bool isNumber = false;

            for (int x = 0; x < password.Length; x++)
            {
                if (char.IsUpper(password[x])) //check single element of current passwoard index for UpperCase letter
                {                             // set isUpper value to true if current element has UpperCase  
                    isUpper = true;
                }
                if (char.IsLower(password[x]))
                {
                    isLower = true;
                }
                if (char.IsNumber(password[x]))
                {
                    isNumber = true;
                }
            }
                //check all variables at onces to see if any have false value
                // return false if any of the above check fails
                if( isNumber == true && isLower == true && isUpper == true )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];

        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();

            for(int i = 0;i < 100; i++)
            {
                if(i % 2 !=0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
