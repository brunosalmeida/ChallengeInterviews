using System;
using System.Collections.Generic;

namespace ChallengeInterviews
{
    public class RemovingDuplicates
    {
        public static int [] Remove(int[] numbers)
        {
            var uniqueNumbers = new List<int>();
            var numbersWithoutDuplicates = new HashSet<int>(numbers);

            foreach (var uniqueNumber in numbersWithoutDuplicates)
            {
                var counter = 0;
                
                foreach (var number in numbers)
                {
                    if (uniqueNumber == number)
                        counter++;
                }

                if (counter == 1)
                {
                    uniqueNumbers.Add(uniqueNumber);
                }
            }

            return uniqueNumbers.ToArray();
        }
    }
}