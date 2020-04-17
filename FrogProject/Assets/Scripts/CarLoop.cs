using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLoop : MonoBehaviour
{
    public GameObject assignedCar;
    public GameObject startPosition;

    private bool loopExit = false;
    private bool taken = false;

    // Update is called once per frame
    void Update()
    {
        if (loopExit && !taken)
        {
            // reset the player
            assignedCar.transform.position = startPosition.transform.position;
            loopExit = false;
            taken = true;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Car"))
        {
            print("Car loop!");
            loopExit = true;
        }
    }
}
