using Game.Components;
using Game.Datas;
using Game.System.FakeMono;
using Game.System.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Actor
{
    public abstract class Actor : MonoBehaviour
    {
        protected List<IComponent> components = new List<IComponent>();
        protected List<IData> datas = new List<IData>();

        private void Start()
        {
            foreach (var component in components)
            {
                foreach (var data in datas)
                {
                    if (component.GetData(data))
                    {
                        break;
                    }
                }

                if (component is IStart)
                {
                    (component as IStart).StartGame();
                }

                if (component is ITick)
                    UpdateManager.AddTick(component as ITick);
            }
        }
    }
}
