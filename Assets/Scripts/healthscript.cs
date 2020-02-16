using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthscript : MonoBehaviour
{

    public static float currenthealth;
    float maxhealth;

    Image health;


    public GameObject satellitespawner;
    public GameObject gameover;
    Transform[] spawnpoints;


    // Start is called before the first frame update
    void Start()
    {
        maxhealth = 100f;
        currenthealth = maxhealth;
        health = GetComponent<Image>();
        spawnpoints = GameObject.FindGameObjectWithTag("earth").GetComponent<earthscript>().spawnpoints;
    }

    // Update is called once per frame
    void Update()
    {
        health.fillAmount = (currenthealth / maxhealth);

        if(currenthealth <=0)
        {
            satellitespawner.SetActive(false);
            foreach(Transform point in spawnpoints)
            {
                point.gameObject.SetActive(false);
            }
            Invoke("Gameover", 1f);
        }
    }

    void Gameover()
    {
        gameover.SetActive(true);
    }
}
