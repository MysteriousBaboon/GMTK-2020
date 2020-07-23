using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Mess : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;

    private int mess = 0;

    public int firstLevel;
    public int secondLevel;
    public int thirdLevel;
    public int forthLevel; 
    public int fifthLevel;

    public Animator playerAnimator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mess = player.GetComponent<Script_Car>().malusControl;
        SpriteRenderer spr = player.GetComponent<SpriteRenderer>();

        if (mess > fifthLevel) print("max");
        else if (mess > forthLevel)
        {
            playerAnimator.SetBool("fifthStage", true);
        }
        else if (mess > thirdLevel)
        {
            playerAnimator.SetBool("fourthStage", true);
        }
        else if (mess > secondLevel)
        {
            playerAnimator.SetBool("thirdStage", true);
        }
        else if (mess > firstLevel)
        {
            playerAnimator.SetBool("secondStage", true);
        }



    }
}
