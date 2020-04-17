using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource[] sfx;
    public AudioSource[] binstance;

    public static AudioManager instance;

    // Use this for initialization
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void PlaySFX(int soundToPlay)
    {
        if (soundToPlay < sfx.Length)
        {
            sfx[soundToPlay].Play();
        }
    }

    public void PlayBinstance(int musicToPlay)
    {
        if (!binstance[musicToPlay].isPlaying)
        {
            StopMusic();

            if (musicToPlay < binstance.Length)
            {
                binstance[musicToPlay].Play();
                binstance[musicToPlay].volume = 0.2f;
            }
        }
    }

    public void PlayBackgroundVolumne(float volume)
    {
        binstance[0].volume = volume;
    }

    public void StopSFX(int sfxNumber)
    {
        if(sfxNumber < sfx.Length)
        {
            sfx[sfxNumber].Stop();
        }
    }

    public void StopMusic()
    {
        for (int i = 0; i < binstance.Length; i++)
        {
            binstance[i].Stop();
        }
    }
}
