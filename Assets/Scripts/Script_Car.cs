using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Car : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;

    public float radius;
    public float elapsedTime = 0;
    public float timeLimit;

    public GameObject arrow;

    public int life;
    public int numberControl;



    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (elapsedTime >= timeLimit)
        {
            if(Input.GetAxis("Control") != 0 && numberControl > 0) TargetClosest();
        }
        if (elapsedTime <= timeLimit) elapsedTime += Time.deltaTime;

        transform.position += transform.up * Time.deltaTime * speed;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput > 0)
        {
            transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);

        }
        else if (horizontalInput < 0)
        {
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {

       
    }




    public void TargetClosest()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");

        float distance = Mathf.Infinity;

        Vector3 curPosition = transform.position;


        foreach (GameObject go in gos)
        {
            float dist = Vector3.Distance(go.transform.position, curPosition);


            if (dist < distance && dist < radius)
            {
                distance = dist;
                GameObject f = Instantiate(arrow, transform.position, transform.rotation);
                f.GetComponent<Script_Arrow>().pos = go.transform.position;
                elapsedTime = 0;
                numberControl -= 1;
                break;

            }
        }

    }
}
