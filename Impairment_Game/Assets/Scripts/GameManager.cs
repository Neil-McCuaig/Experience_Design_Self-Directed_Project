using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [Header("Nearsight Mode")]

    public bool gamemodeNearsight;

    public int maxTime;
    public float currentTime;
    public bool timerActive;

    [Header("Farsight Mode")]

    
    public bool hasGreenJogHurt;

    [Header("Hard of hearing Mode")]

    public bool boughtTheMilk;


    [Header("General Stuff")]

    public GameObject introPanel;
    public GameObject pausePanel;
    public GameObject defeatScreen;
    public GameObject victoryScreen;

    public TextMeshProUGUI timerText;
    
    public bool pauseMode;

    public bool victory;
    public bool defeat;

    //How to prevent the pause from opening and shutting too fast while time is not moving?
    //public float antiPauseSpam;
    //public float antiPauseSpamCurrent;

    // Start is called before the first frame update
    void Start()
    {
        introPanel.SetActive(true);
        currentTime = maxTime;
        timerActive = false;
        victory = false;
        defeat = false;
        pauseMode = false;
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
            Timer(currentTime);
        }

        if (currentTime <= 0 && victory == false)
        {
            timerActive = false;
            defeat = true;
        }

        if (defeat == true)
        {
            defeatScreen.SetActive(true);  
        }

        if (victory == true)
        {
            victoryScreen.SetActive(true);
        }
    }

    public void NearSightBegin()
    {
        timerActive = true;
        Time.timeScale = 1;
        introPanel.SetActive(false);
    }

    public void pauseMenuEnable()
    {
        Debug.Log("Enabling Pause Menu");
        pausePanel.SetActive(true);
        timerActive = false;
        Time.timeScale = 0;
        pauseMode = true;
    }

    public void pauseMenuDisable()
    {
        pausePanel.SetActive(false);
        timerActive = true;
        Time.timeScale = 1;
        pauseMode = false;
    }

    public void Timer(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
