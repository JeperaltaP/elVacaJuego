using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject CreditsPanel;
    public GameObject ConfigurationPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
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
    }

    public void ConfigurationOff()
    {
        ConfigurationPanel.SetActive(false);
    }
}   
