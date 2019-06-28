using Game.System.FakeMono;
using Game.System.TBox;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.System.Manager
{
    [CreateAssetMenu(fileName = "UpdateManager", menuName = "Manager/UpdateManager")]
    public class UpdateManager : ManagerBase, IAwake
    {
        private List<ITick> Ticks = new List<ITick>();

        public void Awake()
        {
            CreatingUpdateInScene();
        }

        private void CreatingUpdateInScene()
        {
            GameObject update = new GameObject("UpdateScene");
            update.AddComponent<UpdateScene>().Setup(Toolbox.Get<UpdateManager>());
            Debug.Log("Создание портативного Update на сцене");
        }

        public static void AddTick(ITick obj)
        {
            Toolbox.Get<UpdateManager>().Ticks.Add(obj);
        }

        public void Tick(float time)
        {
            foreach (var tick in Ticks)
            {
                tick.Tick(time);
            }
        }
    }
}
