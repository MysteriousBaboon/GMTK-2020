using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_NPC : MonoBehaviour
{
    bool isFree = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFree) Debug.Log("FU");
    }

    public void Captured(GameObject gameObject)
    {
       isFree = false;
       gameObject.tag = "Converted";
        gameObject.gameObject.GetComponent<SpriteRenderer>().color = Color.green;

    }
}
