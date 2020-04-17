using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorpseController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            AudioManager.instance.PlaySFX(0);
            print("You just walked on one of your corpses.");
        }
    }
}
