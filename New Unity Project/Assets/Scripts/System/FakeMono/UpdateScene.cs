using Game.System.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.System.FakeMono
{
    public class UpdateScene : MonoBehaviour
    {
        private UpdateManager manager;

        public void Setup(UpdateManager manager)
        {
            this.manager = manager;
        }

        private void Update()
        {
            if (manager == null)
                return;

            manager.Tick(Time.deltaTime);
        }
    }
}
