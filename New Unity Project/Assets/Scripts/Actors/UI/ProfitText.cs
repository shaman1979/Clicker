using Game.Components;
using Game.Messages;
using Game.System.FakeMono;
using Game.System.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Actor
{
    public class ProfitText : Actor
    { 
        private void Awake()
        {
            components.Add(new ChangeText<ProfitMessage>(GetComponent<Text>()));
        }
    }
}
