using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController4 : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            door.transform.position = new Vector3(-45, 7, -48);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();            
    }
}
