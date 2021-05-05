using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashcan : MonoBehaviour
{
    public Transform trashTarget;
    //public GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wrong")
        {
            //FindObjectOfType<AudioManager>().Play("teleport");
            other.transform.position = trashTarget.transform.position;
        }
    }
}
