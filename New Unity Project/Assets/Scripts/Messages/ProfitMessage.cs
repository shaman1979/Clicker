using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Messages
{
    public class ProfitMessage
    {
        private int profit;

        public ProfitMessage(int profit)
        {
            profit = profit;
        }

        public override string ToString()
        {
            return profit.ToString();
        }
    }
}
