﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{

    Text scoretext;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoretext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score : " + score.ToString();
    }
}