using Game.System.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.System.TBox;

namespace Game.System.FakeMono
{
    public class Starter : MonoBehaviour
    {
        [SerializeField]
        private List<ManagerBase> managers;

        private void Awake()
        {
            Debug.Log("Начало инициализации программы. Добавление систем.");
            foreach (var manager in managers)
            {
                Toolbox.Add(manager);
                
                if(manager is IAwake)
                {
                    (manager as IAwake).Awake();
                }
            }

            Debug.Log("Системы добавлены.");
        }
    }
}
