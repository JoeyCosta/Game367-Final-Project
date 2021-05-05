using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    [SerializeField] float startTime = 5f;
    [SerializeField] TextMeshProUGUI timerText;
    float timer = 0f;
    public GameObject GameOverText;

    private void Start()
    {
        GameOverText.SetActive(false);
        StartCoroutine(CountDownTimer());
    }

    private void Update()
    {
        if(timer <= 0)
        {
            EndGame();
        }
    }

    private IEnumerator CountDownTimer()
    {
        timer = startTime;

        do
        {
            timer -= Time.deltaTime;
            FormatText();

            yield return null;
        }
        while (timer > 0);
        
    }

    private void FormatText()
    {
        int minutes = (int)(timer / 60) % 60; ;
        int seconds = (int)(timer % 60);

        timerText.text = "";
        if (minutes > 0)
        {
            timerText.text += minutes + ":";
        }

        if(seconds > 0)
        {
            timerText.text += seconds;
        }
    }

    void EndGame()
    {
        GameOverText.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Losing");
        StartCoroutine(ReloadScene());
    }

    private IEnumerator ReloadScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
