using Game.System.TBox;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.System.Manager
{
    [CreateAssetMenu(fileName ="PubSubManager", menuName = "Manager/PubSubManager")]
    public class PublisherAndSubscriber : ManagerBase
    {
        public Dictionary<Type, Action<object>> handlers = new Dictionary<Type, Action<object>>();

        public static void Publish<T>(T message)
        {
            var handlers = Toolbox.Get<PublisherAndSubscriber>().handlers;

            if(!handlers.ContainsKey(typeof(T)))
            {
                return;
            }
            handlers[typeof(T)].Invoke(message);
        }

        public static void Subscribe<T>(Action<T> handler)
        {
            var handlers = Toolbox.Get<PublisherAndSubscriber>().handlers;

            if (!handlers.ContainsKey(typeof(T)))
            {
                handlers[typeof(T)] = o => { };
            }

            handlers[typeof(T)] =
                (Action<object>)Delegate.Combine(handlers[typeof(T)], (Action<object>)(o => { handler((T)o); }));
        }
    }
}
