using System;

namespace ChallengeInterviews
{
    public class AtmChallenge
    {
        public static int[] Withdraw(int value)
        {
            var oneHundredEuroBillCounter = 0;
            var fifityEurosBillCounter = 0;
            var tenEurosBillCounter = 0;
            var billCounter = 0;

            switch (value)
            {
                case 100:
                    return new int[] {100};
                case 50:
                    return new int[] {50};
                case 10:
                    return new int[] {10};
            }

            while (value > 0)
            {
                if (value >= 100)
                {
                    billCounter++;
                    oneHundredEuroBillCounter++;
                    value -= 100;
                }

                if ((value is < 100 and >= 50))
                {
                    billCounter++;
                    fifityEurosBillCounter++;
                    value -= 50;
                }

                if ((value is < 50 and >= 10))
                {
                    billCounter++;
                    tenEurosBillCounter++;
                    value -= 10;
                }

                if (value is < 10 and > 0)
                {
                    throw new Exception("No bills available");
                }
            }

            var bills = new int[billCounter];
            var index = 0;

            if (oneHundredEuroBillCounter > 0)
            {
                for (var j = 0; j < oneHundredEuroBillCounter; j++)
                {
                    bills[index + j] = 100;
                }

                index += oneHundredEuroBillCounter;
            }

            if (fifityEurosBillCounter > 0)
            {
                for (var j = 0; j < fifityEurosBillCounter; j++)
                {
                    bills[index + j] = 50;
                }

                index += fifityEurosBillCounter;
            }

            if (tenEurosBillCounter <= 0) return bills;
            {
                for (var j = 0; j < tenEurosBillCounter; j++)
                {
                    bills[index + j] = 10;
                }
            }

            return bills;
        }
    }
}