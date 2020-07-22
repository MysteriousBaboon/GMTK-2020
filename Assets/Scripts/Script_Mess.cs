using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Mess : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;

    private int mess = 0;

    public int[] malusLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mess = player.GetComponent<Script_Car>().malusControl;

    }
}
