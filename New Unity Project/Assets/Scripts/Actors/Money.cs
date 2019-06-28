using Game.Components;
using Game.Datas;
using Game.System.FakeMono;
using Game.System.Manager;
using Game.System.TBox;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Actor.Money
{
    public class Money : Actor, ITick
    {
        private void Awake()
        {
            components.Add(new AddMoney());
            components.Add(new AddProfit());
            datas.Add(new MoneyData());
        }

        public void Tick(float time)
        {

        }
    }
}
