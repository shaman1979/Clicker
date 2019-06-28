﻿using Game.Components;
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
        private List<IComponent> components = new List<IComponent>();
        private List<IData> datas = new List<IData>();

        private void Start()
        {
            components.Add(new AddMoney());
            datas.Add(new MoneyData());

            foreach (var component in components)
            {
                foreach (var data in datas)
                {
                    var typeData = component.GetData();
                    if (component is IComponent<MoneyData>)
                        (component as IComponent<IData>).GetData();


                    var dt = (component as IComponent<IData>).GetData();

                    if (data.GetType() == dt)
                    {
                        (component as IComponent<IData>).Setup(data);
                    }
                }

                if(component is ITick)
                    UpdateManager.AddTick(component as ITick);
            }           
        }

        public void Tick(float time)
        {
            
        }
    }
}