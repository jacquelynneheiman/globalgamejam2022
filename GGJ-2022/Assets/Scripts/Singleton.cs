using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;
    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    public bool IsInitialized
    {
        get
        {
            return instance != null;
        }
    }

    protected virtual void Awake()
    {
        if (IsInitialized)
        {
            Debug.Log("[Singleton] Tried to create a second instance of a Singleton Class");
            GameObject.Destroy(this);
        }
        else
        {
            instance = (T)this;
        }
        DontDestroyOnLoad(this);
    }

    protected virtual void OnDestroy()
    {
        instance = null;
    }

}
