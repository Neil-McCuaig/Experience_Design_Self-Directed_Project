using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    GameManager manager;

    void Start()
    {
        manager = FindAnyObjectByType<GameManager>();
    }

    public void OnPlayNearsightButtonPressed()
    {
        manager.gamemodeNearsight = true;
        SceneManager.LoadScene(1);
    }

    public void OnPlayFarsightButtonPressed()
    {
        SceneManager.LoadScene(2);
    }

    public void OnPlayHardHearingButtonPressed()
    {
        SceneManager.LoadScene(3);
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }

    public void OnReturnButtonPressed()
    {
        manager.gamemodeNearsight = false;
        SceneManager.LoadScene(0);
    }

    public void OnBeginNearsightedPressed()
    {
        manager.NearSightBegin();
    }
}
