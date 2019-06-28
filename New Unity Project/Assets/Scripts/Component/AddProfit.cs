using Game.Datas;
using Game.Messages;
using Game.System.FakeMono;
using Game.System.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Components
{
    public class AddProfit : IComponent<MoneyData>, IStart
    {
        public MoneyData Data;

        public bool GetData(IData data)
        {
            if (data.GetType() == typeof(MoneyData))
            {
                Data = data as MoneyData;
                return true;
            }
            return false;
        }

        public void StartGame()
        {
            PublisherAndSubscriber.Subscribe<ProfitMessage>(BuyUpgrade);
        }

        public void BuyUpgrade(ProfitMessage message)
        {
            Data.Profit += int.Parse(message.ToString());
        }

        public void Setup(MoneyData data)
        {
            
        }
    }
}
