using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Datas
{
    public class MoneyData : IData
    {
        public int Money { get; set; } = 0;
        public int Profit { get; set; } = 1;
    }
}
