using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Script_Score : MonoBehaviour
{
    Text score;
    public int enemies;

    // Start is called before the first frame update
    void Start()
    {

        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Enemy");
        enemies = gos.Length;
        score.text = enemies.ToString();
    }
}
