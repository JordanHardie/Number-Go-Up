using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance_;
    public static T Instance
    {
        get
        {
            if (instance_ == null)
            {
                instance_ = FindObjectOfType<T>();
                if (instance_ == null)
                {
                    GameObject singleton = new GameObject(typeof(T).Name);
                    singleton.AddComponent<T>(); // Awake gets called inside AddComponent
                }
            }
            return instance_;
        }
    }

    protected virtual void Awake()
    {
        if (instance_ == null)
        {
            instance_ = this as T;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            print(gameObject);
            Destroy(gameObject);
        }
    }
}