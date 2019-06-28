using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Messages
{
    public class MoneyMessage
    {
        public int Money;

        public MoneyMessage(int money)
        {
            Money = money;
        }

        public override string ToString()
        {
            return Money.ToString();
        }
    }
}
