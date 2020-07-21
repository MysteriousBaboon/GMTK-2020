using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Player : MonoBehaviour
{
    public float speed;
    public float radius;

    void Start()
    {

    }

    void Update()
    {
        FindClosest();
        Debug.Log(radius);

    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0 ) * speed * Time.deltaTime);
    }

    public GameObject FindClosest()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Free");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance && curDistance < radius)
            {
                closest = go;
                distance = curDistance;
            }
        }
        if (closest != null)
        {
            closest.gameObject.GetComponent<Script_NPC>().Captured(closest);
        }
        return null;
    }



}

