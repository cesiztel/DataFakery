using System;

namespace DataFakery.Provider
{
    public class Base
    {
        /// <summary> This method returns a random number between 0 and 9 </summary>
        public static int RandomDigit()
        {
            return new Random().Next(0, 10);
        }

        /// <summary> This method returns a random number between 1 and 9 </summary>
        public static int RandomDigitNotNull()
        {
            return new Random().Next(1, 10);
        }

        /// <summary> This method returns a random number between 1 and 9, which cannot be except 
        /// <param name="except"></param>
        /// </summary>
        public static int RandomDigitNot(int except)
        {
            var result = NumberBetween(0, 9);
            if (result >= except)
            {
                result++;
            }

            return result;
        }

        /// <summary> This method returns a random number between value1 and value2 (any order) 
        /// <param name="value1">Integer first value. Default 0</param>
        /// <param name="value2">Integer second value. Default to 32 bit max integer, ie 2147483647.</param>
        /// </summary>   
        public static int NumberBetween(int value1 = 0, int value2 = 2147483646)
        {
            var min = value1 < value2 ? value1 : value2;
            var max = value1 < value2 ? value2 : value1;

            return new Random().Next(min, max + 1);
        }
    }
}