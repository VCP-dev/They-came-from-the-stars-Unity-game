using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{

    public GameObject tank;
    public GameObject turret;

    GameObject enemy;

   
    private float spawntime,startspawntime;
    
   
    // Start is called before the first frame update
    void Start()
    {
        spawntime = Random.Range(6f, 9f);
        startspawntime = Random.Range(2f,5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > startspawntime)
        {
            Invoke("spawnenemy", spawntime);
            startspawntime = Time.time + spawntime;
        }
    }


    void spawnenemy()
    {
        StartCoroutine("spawn");
    }

    IEnumerator spawn()
    {
        
        if(Random.Range(1,5) > 2.3f)
        {
            Instantiate(tank, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(turret, transform.position, transform.rotation);
        }
        yield return null;
    }

}
