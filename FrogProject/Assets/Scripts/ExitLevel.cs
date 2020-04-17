using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitLevel : MonoBehaviour
{
    public Vector3 startLocation;
    public GameObject player;
    public string levelNameToLoad;
    public List<GameObject> fireworksCollection;

    private bool levelExit = false;
    private bool taken = false;

    private void Start()
    {
        if (!levelExit)
        {
            // disable fireworks
            foreach(GameObject gameObject in fireworksCollection)
            {
                gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (levelExit && !taken)
    //    {
    //        // reset the player
    //        player.transform.position = startLocation;
    //        levelExit = false;
    //        taken = true;
    //    }
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name.Equals("Player"))
    //    {
    //        print("Level completed!");
    //        levelExit = true;
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            // trigger the confetti explosion to let player know they have completed the level
            // enable fireworks
            foreach (GameObject gameObject in fireworksCollection)
            {
                gameObject.SetActive(true);
            }

            // sound effect
            AudioManager.instance.PlaySFX(3);

            print("You made it to the other side of the level!");

            // put in a delay so that the player can take in the moment

            // load the next level

            levelExit = true;

        }
    }
}
