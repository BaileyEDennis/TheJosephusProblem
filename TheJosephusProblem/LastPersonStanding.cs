using System;
using System.Collections.Generic;
using System.Text;

namespace TheJosephusProblem
{
    public class LastPersonStanding
    {
        public int lastPerson (int numberOfPeople, int killingInterval)
        {
            var groupSize = numberOfPeople;
            var interval = killingInterval;

            if (groupSize == 1)
            {
                return 1;
            }
            else
            {
                return (lastPerson(groupSize - 1, interval) + interval - 1) % groupSize + 1;
            }
           
        }
    }
}
