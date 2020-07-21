using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Circle : MonoBehaviour
{
    public GameObject character;
    public GameObject self;

    void Update()
    {
        float radius = character.gameObject.GetComponent<Script_Player>().radius;
        radius = radius / 2;
        Debug.Log(radius);
        self.transform.localScale = new Vector3(1f*radius, 1f*radius, 1f);
    }
}
