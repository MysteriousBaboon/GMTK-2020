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
        else if (mess > forthLevel) print("4");
        else if (mess > thirdLevel) spr.color = Color.green;
        else if (mess > secondLevel) spr.color = Color.red;
        else if (mess > firstLevel) spr.color = Color.blue;



    }
}
