using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    public Vector3 startPosition;

    private void OnCollisionEnter(Collision collision)
    {
        print("collide with car!");

        if (collision.gameObject.name.Equals("Player"))
        {
            // sound effect
            AudioManager.instance.PlaySFX(2);

            StartCoroutine("Death");

            // respawn player at start of level
            SceneManager.LoadScene("Level_1");
        }

        //if (collision.gameObject.name.Equals("Car_Looper"))
        //{
        //    print("Loop to beginning.");
        //    gameObject.transform.position = startPosition;
        //}
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
