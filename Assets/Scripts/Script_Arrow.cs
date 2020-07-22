using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Arrow : MonoBehaviour
{
    public float speedDegenerescence;
    public float speed;
    public float slowMo = 5;
    public Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(slowMo > Vector3.Distance(pos, transform.position))Time.timeScale = 0.25f;
        if (speed < 0.005 || transform.position == pos)
        {
            Time.timeScale = 1f;
            Destroy(this.gameObject);
        }
            
        speed *= speedDegenerescence;

        transform.position = Vector3.MoveTowards(transform.position, pos, speed);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Time.timeScale = 1f;
            Destroy(this.gameObject);
        }
    }

}


