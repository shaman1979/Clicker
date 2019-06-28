using System.Collections;
using System.Collections.Generic;
using Game.Datas;
using Game.Messages;
using Game.System.FakeMono;
using Game.System.Manager;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Components
{
    public class ChangeText<T> : IComponent, IStart
    {
        private Text text;

        public ChangeText(Text text)
        {
            this.text = text;
        }

        public bool GetData(IData data)
        {
            return false;
        }

        public void StartGame()
        {
            PublisherAndSubscriber.Subscribe<T>(SetText);
        }

        private void SetText(T message)
        {
            text.text = message.ToString();
        }
    }
}
