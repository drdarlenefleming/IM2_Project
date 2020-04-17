using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefManager : MonoBehaviour
{
    private const string CORPSE = "corpse";
    private static int maxCorpseCount = 10;
    
    public static int GetCorpseCount()
    {
        if (PlayerPrefs.HasKey(CORPSE))
        {
            return PlayerPrefs.GetInt(CORPSE);
        }
        else
        {
            return 0;
        }
    }

    // limit the number of corpses that can be left behind
    public static void SetCorpseCount(int count)
    {
        int temp = PlayerPrefs.GetInt(CORPSE);
        temp += count;

        if(temp < maxCorpseCount)
        {
            PlayerPrefs.SetInt(CORPSE, temp);
        }
    }
}
