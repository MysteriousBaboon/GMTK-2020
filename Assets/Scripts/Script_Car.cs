using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Car : MonoBehaviour
{
    public float speed;
    public GameObject arrow;
    public float radius;
    public float elapsedTime = 0;
    public float timeLimit;



    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (elapsedTime >= timeLimit)
        {
            FindClosest();
            elapsedTime = 0;

        }
        if (elapsedTime <= timeLimit) elapsedTime += Time.deltaTime;
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime);
    }




    public GameObject FindClosest()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;

        float distance = Mathf.Infinity;

        Vector3 curPosition = transform.position;


        foreach (GameObject go in gos)
        {
            float dist = Vector3.Distance(go.transform.position, curPosition);


            if (dist < distance && dist < radius)
            {
                closest = go;
                distance = dist;
                GameObject f = Instantiate(arrow, transform.position, transform.rotation);
                print(f);
                f.GetComponent<Script_Arrow>().pos = closest.transform.position;

            }
        }

        return null;

    }
}
