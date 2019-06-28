﻿
using Game.Datas;
using Game.Messages;
using Game.System.FakeMono;
using Game.System.Manager;
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
            PublisherAndSubscriber.Publish<MoneyMessage>(new MoneyMessage(data.Money));
        }

        public bool GetData(IData data)
        {
            if(data.GetType() == typeof(MoneyData))
            {
                Data = data as MoneyData;
                return true;
            }
            return false;
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
