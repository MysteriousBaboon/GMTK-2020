using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Factory : MonoBehaviour
{
    public GameObject NPC;
    public float elapsedTime;
    public float timeLimit;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= timeLimit)
        {
            Instantiate(NPC);
            elapsedTime = 0;
        }
    }
}
