using Game.System.Absctact;
using Game.System.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.System.TBox
{
    public class Toolbox : Singlton<Toolbox>
    {
        private Dictionary<Type, IManager> managers = new Dictionary<Type, IManager>();

        public static void Add(IManager manager)
        {
            var managers = Toolbox.Instance.managers;
            if (!managers.ContainsKey(manager.GetType()))
            {
                managers.Add(manager.GetType(), manager);
                Debug.Log(manager + " добавлен в ToolBox");
            }
        }

        public static T Get<T>() where T : class, new()
        {
            var managers = Toolbox.Instance.managers;
            if (managers.ContainsKey(typeof(T)))
            {
                return managers[typeof(T)] as T;
            }
            else
            {
                Debug.LogError(typeof(T) + " Не существует!!!");
                return null;
            }
        }
    }
}
