﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Arrow : MonoBehaviour
{
    public float speedDegenerescence;
    public float speed;
    public float slowMo = 5;
    public Vector3 pos;

    public AudioClip timestop;
    AudioSource m_MyAudioSource;


    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (slowMo > Vector3.Distance(pos, transform.position))
        {
            m_MyAudioSource.Play();

            Time.timeScale = 0.5f;
        }
        if (speed < 0.005 || transform.position == pos)
        {
            Time.timeScale = 1f;
            Destroy(this.gameObject);
        }
            

    }

    void FixedUpdate()
    {
        speed *= speedDegenerescence;

        transform.position = Vector3.MoveTowards(transform.position, pos, speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Script_Enemy>().life -= 1;
            Time.timeScale = 1f;
            Destroy(this.gameObject);
        }
    }

}


