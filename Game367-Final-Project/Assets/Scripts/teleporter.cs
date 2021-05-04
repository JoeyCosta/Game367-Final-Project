using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public Transform teleportTarget;
    //public GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("teleport");
            other.transform.position = teleportTarget.transform.position;
        }
    }
}
