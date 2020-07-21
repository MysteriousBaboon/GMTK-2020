using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Enemy : MonoBehaviour
{
    public Transform player;
    public GameObject projectile;
 
    public float range;
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
            if (player)
            {
                float dist = Vector3.Distance(player.position, transform.position);
                if (dist < range)
                {
                    Instantiate(projectile, transform.position, transform.rotation);

                    elapsedTime = 0;
                }
            }
        }
        if (elapsedTime <= timeLimit) elapsedTime += Time.deltaTime;
    }
}
