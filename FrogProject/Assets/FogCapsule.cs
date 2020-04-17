using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogCapsule : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            print("Not the player!");

            // maybe toss the player back out?

        }
    }
}
