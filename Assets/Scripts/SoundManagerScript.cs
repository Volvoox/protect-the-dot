using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip destroy;
    public static AudioClip score;
    public static AudioClip grow_up;


    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        destroy = Resources.Load<AudioClip>("destroy");
        score = Resources.Load<AudioClip>("score");
        grow_up = Resources.Load<AudioClip>("growup");
        audioSrc = GetComponent<AudioSource>();

    }

    public static void PlaySound()
    {
        audioSrc.volume = 0.8f;
        audioSrc.PlayOneShot(destroy);
    }
    public static void ScoreSound()
    {
        audioSrc.volume = 0.8f;
        audioSrc.PlayOneShot(score);
    }
    public static void GrowUpSound()
    {
        audioSrc.volume = 0.2f;
        audioSrc.PlayOneShot(grow_up);
        
    }


}
