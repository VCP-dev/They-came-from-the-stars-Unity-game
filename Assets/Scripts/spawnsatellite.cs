using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnsatellite : MonoBehaviour
{

    public GameObject satellite;

    public Transform[] positions;

    float startspawntime;
    float spawnrate;

    // Start is called before the first frame update
    void Start()
    {
        spawnrate = 10f;
        startspawntime = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > startspawntime)
        {
            Instantiate(satellite, positions[(int)Random.Range(0,4)].position, Quaternion.identity);
            startspawntime = Time.time + spawnrate;
        }
    }
}
