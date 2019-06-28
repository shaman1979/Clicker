
using Game.Datas;
using Game.System.FakeMono;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Game.Components
{
    public class AddMoney : IComponent<MoneyData>, ITick
    {
        private MoneyData Data; 
        public void Add(MoneyData data)
        {
            data.Money += data.Profit;
            Debug.Log(data.Money.ToString());
        }

        public Type GetData()
        {
            return Data.GetType();
        }

        public void Setup(MoneyData action)
        {
            Data = action;
        }

        public void Tick(float time)
        {
            if (Data == null)
                return;

            Add(Data);
        }
    }
}
