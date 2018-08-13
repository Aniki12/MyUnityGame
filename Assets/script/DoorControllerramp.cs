using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControllerramp : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            door.transform.position = new Vector3(28, 0, -41);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();            
    }
}
