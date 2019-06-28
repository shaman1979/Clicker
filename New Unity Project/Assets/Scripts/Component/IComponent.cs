﻿using Game.Datas;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Components
{
    public interface IComponent
    {
       Type GetData();
    }

    public interface IComponent<T> : IComponent where T : IData
    {
        void Setup(T data);              
    }
}
