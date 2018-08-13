using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FieldOfVision : MonoBehaviour
{
    public bool isDetected = false;
    private float health = 1;
    public Image healthBar;
    public float dps = 1;

    private void Update()
    {
        if (isDetected == true)
        {
            //Geeft damage per tijd
            health -= Time.deltaTime * dps;
            //bepaald de lengte van healthbar
            healthBar.rectTransform.sizeDelta = new Vector2(1000 * health, 25);
            //Game over wanneer je geen health meer hebt
            if (health <= 0)
            SceneManager.LoadScene(1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "guard")
        { isDetected = true;
            Debug.Log("Detected!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "guard")
        { isDetected = false;
            Debug.Log("NotDetected!");
        }
    }

}