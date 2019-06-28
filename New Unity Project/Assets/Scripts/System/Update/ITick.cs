using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.System.FakeMono
{
    public interface ITick
    {
        void Tick(float time);
    }
}
