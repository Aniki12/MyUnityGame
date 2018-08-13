using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController6 : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            door.transform.position = new Vector3(-32, 0, 64);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();            
    }
}
