using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    public Vector3 startPosition;
    public int deathSFX, hornSFX, driveSFX;

// TODO add the quiet hum of the car

    // possibly put this in the player controller.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            // sound effect: death
            AudioManager.instance.PlaySFX(deathSFX);

            StartCoroutine("Death");

            // respawn player at start of level
            SceneManager.LoadScene("Level_1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            // sound effect: horn
            AudioManager.instance.PlaySFX(hornSFX);
        }
    }

    //TODO:  need to fine tune this...
    IEnumerator Death()
    {
        print("Just ran into a car! You are dead!");

        //// have the corpse appear
        //corpse.gameObject.SetActive(true);

        //// need to get the transform of corpse to add the leftover corpse
        //corpsePosition = corpse.gameObject.transform;

        //// drop the leftover corpse 
        //leftBehindCorpse.gameObject.SetActive(true);
        //leftBehindCorpse.gameObject.transform.position = new Vector3(
        //                                                    corpsePosition.position.x,
        //                                                    corpsePosition.position.y,
        //                                                    corpsePosition.position.z);

        //// disable any body parts that the living character would have
        //arm1.gameObject.SetActive(false);
        //arm2.gameObject.SetActive(false);

        // add to the corpse count tracking
        PlayerPrefManager.SetCorpseCount(1);

        yield return new WaitForSeconds(5.0f);
    }
}
