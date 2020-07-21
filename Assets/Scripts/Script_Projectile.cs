using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Projectile : MonoBehaviour
{
    public float speedDegenerescence;
    public float speed;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gos;

        gos = GameObject.FindGameObjectsWithTag("Character");
        pos = gos[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(speed < 0.005 || transform.position == pos) Destroy(this.gameObject);
        speed *= speedDegenerescence;



        transform.position = Vector3.MoveTowards(transform.position, pos , speed);
    }
}
