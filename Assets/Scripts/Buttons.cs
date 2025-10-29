using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject CreditsPanel;
    public GameObject ConfigurationPanel;
    public GameObject PauseMenu;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void CreditsOn()
    {
        CreditsPanel.SetActive(true);
    }

    public void CreditsOff()
    {
        CreditsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ConfigurationOn()
    {
        ConfigurationPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ConfigurationOff()
    {
        ConfigurationPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void PauseOn()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PauseOff()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

}   
