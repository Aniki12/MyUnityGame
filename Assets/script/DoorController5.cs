using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController5 : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            door.transform.position = new Vector3(72, 7, 42);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();            
    }
}
