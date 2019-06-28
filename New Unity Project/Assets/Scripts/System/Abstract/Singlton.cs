using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.System.Absctact
{
    public class Singlton<T> where T : new()
    {
        public static T Instance = new T();
    }
}

