using System;

namespace ChallengeInterviews
{
    public class AtmChallenge
    {
        public static int[] Withdraw(int value)
        {
            int oneHundredEuroBillCounter = 0;
            int fifityEurosBillCounter = 0;
            int tenEurosBillCounter = 0;

            int amountAvailable = 1000;
            int billCounter = 0;

            if (amountAvailable < value)
                return new int[0];

            if (value == 100)
                return new int[] {100};

            if (value == 50)
                return new int[] {50};

            if (value == 10)
                return new int[] {10};

            while (value > 0)
            {
                if (value >= 100)
                {
                    billCounter++;
                    oneHundredEuroBillCounter++;
                    value -= 100;
                    amountAvailable -= 100;
                }

                if ((value is < 100 or >= 50))
                {
                    billCounter++;
                    fifityEurosBillCounter++;
                    value -= 50;
                    amountAvailable -= 50;
                }

                if ((value is < 50 and >= 10))
                {
                    billCounter++;
                    tenEurosBillCounter++;
                    value -= 10;
                    amountAvailable -= 10;
                }

                if (value is < 10 and > 0)
                {
                    throw new Exception("No bills available");
                }
            }

            int[] bills = new int[billCounter];

            for (int i = 0; i < bills.Length - 1; i++)
            {
                for (int j = 0; j < oneHundredEuroBillCounter; j++)
                {
                    bills[i + j] = 100;
                }
            }

            for (int i = oneHundredEuroBillCounter; i <= bills.Length - 1; i++)
            {
                for (int j = 0; j < fifityEurosBillCounter; j++)
                {
                    bills[i + j] = 50;
                }
            }

            for (int i = fifityEurosBillCounter > 0 ? fifityEurosBillCounter : tenEurosBillCounter;
                i <= bills.Length - 1;
                i++)
            {
                for (int j = 0; j < (fifityEurosBillCounter > 0 ? fifityEurosBillCounter : tenEurosBillCounter); j++)
                {
                    bills[i + j] = fifityEurosBillCounter > 0 ? 50 : 10;
                }
            }

            return bills;
        }
    }
}