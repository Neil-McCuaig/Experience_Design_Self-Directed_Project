using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void OnPlayNearsightButtonPressed()
    {
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
        SceneManager.LoadScene(0);
    }
}
