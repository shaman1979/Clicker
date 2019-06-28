using Game.Components;
using Game.Messages;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Actor
{
    public class MoneyText : Actor
    {
        private void Awake()
        {
            components.Add(new ChangeText<MoneyMessage>(GetComponent<Text>()));
        }
    }
}
