using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Nearsight Mode")]

    public bool gamemodeNearsight;

    public int maxTime;
    public float currentTime;
    public bool timerActive;

    public bool victory;
    public bool defeat;

    [Header("General Stuff")]

    public GameObject introPanel;

    // Start is called before the first frame update
    void Start()
    {
        introPanel.SetActive(true);
        currentTime = maxTime;
        timerActive = false;
        victory = false;
        defeat = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gamemodeNearsight == true && timerActive == false)
        {
            Time.timeScale = 0;
        }

        if (timerActive == true)
        {
            currentTime -= Time.deltaTime;
        }

        if (currentTime <= 0 && victory == false) 
        { 
            defeat = true;
        }
    }

    public void NearSightBegin()
    {
        timerActive = true;
        Time.timeScale = 1;
        introPanel.SetActive(false);
    }
}
