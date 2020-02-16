using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbuttonscript : MonoBehaviour
{
    public GameObject tutorial;

    public void closetutorial()
    {
        tutorial.SetActive(false);
    }
}
