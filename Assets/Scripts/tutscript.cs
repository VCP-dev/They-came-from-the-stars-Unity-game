using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutscript : MonoBehaviour
{

    public GameObject tutorial;
    bool isactive;

    // Start is called before the first frame update
    void Start()
    {
        tutorial.SetActive(false);
        isactive = false;
    }

    public void tutorialactive()
    {
        if(isactive)
        {
            isactive = false;
            tutorial.SetActive(isactive);
        }
        else
        {
            isactive = true;
            tutorial.SetActive(isactive);
        }
    }
}
