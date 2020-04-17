using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterKill : MonoBehaviour
{
    public Vector3 startLocation;
    public GameObject player;
    public GameObject corpse;
    public GameObject leftBehindCorpse;
    public GameObject arm1, arm2;


    private Transform corpsePosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals(player.name))
        {
            StartCoroutine("Death");
            
            // respawn player at start of level
            SceneManager.LoadScene("Level_1");
        }
    }

    IEnumerator Death()
    {
        print("You are in the water! You will die.");

        // sound effect
        AudioManager.instance.PlaySFX(2);

        // have the corpse appear
        corpse.gameObject.SetActive(true);

        // need to get the transform of corpse to add the leftover corpse
        corpsePosition = corpse.gameObject.transform;

        // drop the leftover corpse 
        leftBehindCorpse.gameObject.SetActive(true);
        leftBehindCorpse.gameObject.transform.position = new Vector3(
                                                            corpsePosition.position.x, 
                                                            corpsePosition.position.y, 
                                                            corpsePosition.position.z);

        // disable any body parts that the living character would have
        arm1.gameObject.SetActive(false);
        arm2.gameObject.SetActive(false);

        // add to the corpse count tracking
        PlayerPrefManager.SetCorpseCount(1);

        yield return new WaitForSeconds(5.0f);
    }
}
