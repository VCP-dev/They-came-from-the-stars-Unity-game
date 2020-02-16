using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Playerscript : MonoBehaviour
{

    float movespeed = 170f;
    float firerate;
    float nextfire;

    public float movement;

    public GameObject laser;
    public GameObject explosion;


    public GameObject pausedsign;
    public GameObject healthbarbackground;
    public GameObject healthbar;
    public GameObject Score;
    public GameObject healthtext;
    public GameObject leftbutton;
    public GameObject rightbutton;
    public GameObject shootbutton;



    // Start is called before the first frame update
    void Start()
    {
        firerate = 0.19f;
        nextfire = 0f;
        pausedsign.SetActive(false);
        healthbarbackground.SetActive(true);
        healthbar.SetActive(true);
        Score.SetActive(true);
        healthtext.SetActive(true);

        //leftbutton.SetActive(true);
        //rightbutton.SetActive(true);              ////   controls for android
        //shootbutton.SetActive(true);

        leftbutton.SetActive(false);
        rightbutton.SetActive(false);
        shootbutton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //////if (CrossPlatformInputManager.GetButton("SHOOT") && Time.time > nextfire)              ////    for android
        //////{
        //////    nextfire = Time.time + firerate;
        //////    Instantiate(laser, transform.position, transform.rotation);
        //////}

        if(Input.GetKey(KeyCode.DownArrow) && Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            Instantiate(laser, transform.position, transform.rotation);
        }

        if (healthscript.currenthealth <= 0)
        {
            Destroy(gameObject, 0f);
            Instantiate(explosion, transform.position, Quaternion.identity);            
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
            pausedsign.SetActive((Time.timeScale == 0) ? true : false);
        }

        movement = Input.GetAxis("Horizontal");

        /////movement = CrossPlatformInputManager.GetAxis("Horizontal");             ////  for android
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.deltaTime * -movespeed);      
    }

       
}
