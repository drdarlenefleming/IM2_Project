using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    /**
     * These two methods are for keeping the player from 
     * falling off the logs.
     */
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "MovingLog")
        {
            transform.parent = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "MovingLog")
        {
            transform.parent = null;
        }
    }
    // end of methods used to keep the player on the log.
}
