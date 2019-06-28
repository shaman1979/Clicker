using Game.System.FakeMono;
using Game.System.TBox;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.System.Manager
{
    [CreateAssetMenu(fileName = "TimerManager", menuName = "Manager/TimerManager")]
    public class TimerManager : ManagerBase,IAwake
    {
        public Action handlers;
        public float time;

        public void Awake()
        {
            handlers = () => { };
            CreatingTimerInScene();
        }

        private void CreatingTimerInScene()
        {
            GameObject update = new GameObject("TimerScene");
            update.AddComponent<IEnumeratorScene>().Setup(Toolbox.Get<TimerManager>());
            Debug.Log("Создание портативного Timer на сцене");
        }

        public static void Add(Action method)
        {
            Toolbox.Get<TimerManager>().handlers += method;
        }
    }
}
