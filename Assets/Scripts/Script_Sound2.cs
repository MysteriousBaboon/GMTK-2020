using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Sound2 : MonoBehaviour
{

    private static Script_Sound2 instance = null;
    public static Script_Sound2 Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
