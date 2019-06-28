using Game.System.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.System.FakeMono
{
    public class TimerInScene : MonoBehaviour
    {
        TimerManager manager;

        public void Setup(TimerManager manager)
        {
            this.manager = manager;
            StartCoroutine(StartTimer());
        }

        public IEnumerator StartTimer()
        {
            while(true)
            {
                manager.handlers.Invoke();
                yield return new WaitForSeconds(manager.time);
            }
        }
    }
}
