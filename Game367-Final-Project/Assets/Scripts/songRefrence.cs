using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songRefrence : MonoBehaviour
{
    public AudioClip triggerSound; //this is defining an audio clip and naming it triggerSound
    AudioSource audioSource; //this is defining the audio source and naming it audioSource
    public bool playOnce = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //we have to bring in this AudioSource component in order to playsounds
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other) //this is the event for colliding with the object
    {
        if (triggerSound != null) //if trigger sound exists
        {
            StartCoroutine(playThisSong());
            //plays the sound you specify(the name of the sound, Volume)
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (playOnce = true)
        {
            Destroy(this);
        }

    }

    IEnumerator playThisSong()
    {
        yield return new WaitForSeconds(2);
        audioSource.PlayOneShot(triggerSound, 0.7f);

    }
}

