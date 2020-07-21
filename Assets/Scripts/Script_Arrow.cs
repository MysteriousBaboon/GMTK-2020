using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Arrow : MonoBehaviour
{
    public float speedDegenerescence;
    public float speed;
    public Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (speed < 0.005 || transform.position == pos) Destroy(this.gameObject);
        speed *= speedDegenerescence;



        transform.position = Vector3.MoveTowards(transform.position, pos, speed);
    }
}


