using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyBgMusic : MonoBehaviour
{
    private static DontDestroyBgMusic instance = null;
    public static DontDestroyBgMusic Instance
    {
        get { return instance; }
        // Start is called before the first frame update
    }
    private void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);

    }
}
