﻿using System.Collections.Generic;

namespace System
{
    /// <summary>
    /// A statically compiled "singleton" used to store objects throughout the 
    /// lifetime of the app domain. Not so much singleton in the pattern's 
    /// sense of the word as a standardized way to store single instances.
    /// 单例容器--基于泛型的单例容器，相当于为没中Type创建单例模式
    /// </summary>
    /// <typeparam name="T">The type of object to store.</typeparam>
    /// <remarks>Access to the instance is not synchrnoized.</remarks>
    public class Singleton<T> : Singleton where T:new()
    {
        static object syncRoot = new object();

        static T instance;

        /// <summary>The singleton instance for the specified type T. Only one instance (at the time) of this object for each type of T.</summary>
        public static T Instance
        {
            get
            {

                if (null == instance)
                {
                    lock (syncRoot)
                    {
                        instance = new T();

                        //注册单例的类型到等级表
                        AllSingletons[typeof(T)] = instance;
                    }
                }

                return instance;

            }
        }


    }

    /// <summary>
    /// Provides a singleton list for a certain type.
    /// 提供一个集合类型的单例列表
    /// </summary>
    /// <typeparam name="T">The type of list to store.</typeparam>
    public class SingletonList<T> : Singleton<List<T>>
    {
  
        /// <summary>The singleton instance for the specified type T. Only one instance (at the time) of this list for each type of T.</summary>
        public new static IList<T> Instance
        {
            get { return Singleton<List<T>>.Instance; }
        }
    }

    /// <summary>
    /// Provides a singleton dictionary for a certain key and vlaue type.
    /// 提供字典类型的单例
    /// </summary>
    /// <typeparam name="TKey">The type of key.</typeparam>
    /// <typeparam name="TValue">The type of value.</typeparam>
    public class SingletonDictionary<TKey, TValue> : Singleton<Dictionary<TKey, TValue>>
    {
       
        /// <summary>The singleton instance for the specified type T. Only one instance (at the time) of this dictionary for each type of T.</summary>
        public new static IDictionary<TKey, TValue> Instance
        {
            get { return Singleton<Dictionary<TKey, TValue>>.Instance; }
        }
    }

    /// <summary>
    /// Provides access to all "singletons" stored by <see cref="Singleton{T}"/>.
    /// </summary>
    public class Singleton
    {
        static Singleton()
        {
            allSingletons = new Dictionary<Type, object>();
        }

        static readonly IDictionary<Type, object> allSingletons;

        /// <summary>Dictionary of type to singleton instances.</summary>
        public static IDictionary<Type, object> AllSingletons
        {
            get { return allSingletons; }
        }
    }
}
