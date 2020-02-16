using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankscript : MonoBehaviour
{

    private float movespeed;

    float startspawntime;
    float spawnrate;
    float direction;

    public GameObject shell;

    
    // Start is called before the first frame update
    void Start()
    {
        movespeed = 13f;
        startspawntime = 3f;
        spawnrate = 1.34f;
        direction = (Random.Range(-1f, 1.13f) > 0) ? 1 : -1;
    }

    // Update is called once per frame
    void Update()
    {        
        if(Time.time > startspawntime)
        {
            Instantiate(shell, transform.position,transform.rotation);
            startspawntime = Time.time + spawnrate;
        }
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, direction * Time.deltaTime * -movespeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="laser")
        {
            Destroy(gameObject, 0f);
            scorescript.score += 10;
        }
    }
}
