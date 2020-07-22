using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Script_Score : MonoBehaviour
{
    Text score;
    public int enemies;
    public bool chara;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        score = GetComponent<Text>(); 
        GameObject[] playerAr = GameObject.FindGameObjectsWithTag("Character");
        player = playerAr[0];

    }

    // Update is called once per frame
    void Update()
    {
        if(!chara)
        { 
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Enemy");
        enemies = gos.Length;
        score.text = enemies.ToString();
        }
        else
        {
            score.text = player.GetComponent<Script_Car>().numberControl.ToString();
        }
    }
}
