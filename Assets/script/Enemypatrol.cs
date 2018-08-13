using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemypatrol : MonoBehaviour {

    public float speed;
    public float rotationTime;
    public float minimunTime;
    public float maximunTime;
    private float targetDirection;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //Zorgt ervoor dat de enemy voortbeweegt
        transform.position += transform.forward * speed;
        
        //Kijkt of de tijd al vertreken is tot de enemy een kwartslag draait.
        if (rotationTime <= Time.time)
        {
            //geeft een willekeurige waarde en telt deze bij de timer op
            float delay = Random.Range(minimunTime, maximunTime);
            rotationTime = Time.time + delay;

            //De helft van de tijd draait de enemy rechtsom en de andere helft linksom
            if (Random.Range(0.0f, 1.0f) < .5f)
            {
                print(transform.rotation.y);
                targetDirection = transform.rotation.eulerAngles.y + 90;
            }
            else
            {
                print(transform.rotation.y);
                targetDirection = transform.rotation.eulerAngles.y - 90;
            }
        }

        // Zorgt ervoor dat de enemy gelijdelijk draait.
        if (transform.rotation.eulerAngles.y != targetDirection)
            transform.rotation = Quaternion.Euler(0, Mathf.LerpAngle(transform.rotation.eulerAngles.y, targetDirection, 1f), 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);

        //Zorgt ervoor dat de enemy omdraait als hij tegen een environmental object botst
        if (collision.gameObject.tag == "Environment")
        {
            targetDirection = transform.rotation.eulerAngles.y - 180;
        }
    }

}
