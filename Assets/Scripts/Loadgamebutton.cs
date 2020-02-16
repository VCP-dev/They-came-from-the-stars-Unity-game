using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadgamebutton : MonoBehaviour
{
    public GameObject canvas;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    public void Loadgame()
    {
        Time.timeScale = 1f;
        canvas.SetActive(false);
    }
}
