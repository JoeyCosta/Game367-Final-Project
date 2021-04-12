using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collectZone : MonoBehaviour
{
    public GameObject displayTextRight;
    public GameObject displayTextWrong;
    

    private void Start()
    {
        displayTextRight.SetActive(false);
        displayTextWrong.SetActive(false);
    }

    private void OnTriggerEnter(Collider boombox)
    {
        if(boombox.gameObject.tag == "Correct")
        {

            DisplayCorrect();
            
        }
        else if (boombox.gameObject.tag == "Wrong")
        {
            DisplayWrong();
            
        }
        
    }


    void DisplayCorrect()
    {

        StartCoroutine(TimeForTextRight());
        
    }
        

    void DisplayWrong()
    {
        StartCoroutine(TimeForTextWrong());  
    }

    private IEnumerator TimeForTextWrong()
    {
        displayTextWrong.SetActive(true);
        yield return new WaitForSeconds(3);
        displayTextWrong.SetActive(false);
    }

    private IEnumerator TimeForTextRight()
    {
        displayTextRight.SetActive(true);
        yield return new WaitForSeconds(5);
        displayTextRight.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
