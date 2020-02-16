using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretscript : MonoBehaviour
{

    public GameObject rocket;

    
    float startspawntime;
    float spawnrate;


    // Start is called before the first frame update
    void Start()
    {
        startspawntime = 0f;
        spawnrate = 1.34f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > startspawntime)
        {
            Instantiate(rocket, transform.position, transform.rotation);
            startspawntime = Time.time + spawnrate;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
            Destroy(gameObject, 0f);
            scorescript.score += 20;
        }
    }
}
