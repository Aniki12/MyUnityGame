using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            door.transform.position = new Vector3(-35, 7, 0);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();            
    }
}
