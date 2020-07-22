using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Enemy : MonoBehaviour
{
    public GameObject projectile;
 
    public float range;
    public float elapsedTime = 0;
    public float timeLimit;

    public int life = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(life <= 0) Destroy(this.gameObject);


        if (elapsedTime >= timeLimit)
        {
            GameObject[] f = GameObject.FindGameObjectsWithTag("Character");

            float dist = Vector3.Distance(f[0].transform.position, transform.position);
            if (dist < range)
            {
                Instantiate(projectile, transform.position, transform.rotation);
            
                elapsedTime = 0;
            }
            
        }
        if (elapsedTime <= timeLimit) elapsedTime += Time.deltaTime;
    }


}
