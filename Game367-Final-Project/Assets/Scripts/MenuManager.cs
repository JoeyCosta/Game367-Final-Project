using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuManager : MonoBehaviour
{
    public GameObject settingsMenuPanel;
    public GameObject howToPlayPanel;
    public AudioMixer audioMixer;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


    public void StartGame()
    {
        FindObjectOfType<AudioManager>().Play("MenuSelect");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SettingsMenu()
    {
        FindObjectOfType<AudioManager>().Play("MenuSelect");
        settingsMenuPanel.SetActive(true);
    }

    public void HowToPlayMenu()
    {
        FindObjectOfType<AudioManager>().Play("MenuSelect");
        howToPlayPanel.SetActive(true);
    }

    public void BackButton()
    {
        FindObjectOfType<AudioManager>().Play("MenuBack");
        
        settingsMenuPanel.SetActive(false);
        howToPlayPanel.SetActive(false);
        
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }

}
