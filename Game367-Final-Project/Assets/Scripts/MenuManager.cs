using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuManager : MonoBehaviour
{
    public GameObject settingsMenuPanel;
    public AudioMixer audioMixer;


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

    public void BackButton()
    {
        FindObjectOfType<AudioManager>().Play("MenuBack");
        settingsMenuPanel.SetActive(false);
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