using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip backGroundMusic;
    static AudioSource audioSource;
    void Start()
    {
        backGroundMusic = Resources.Load<AudioClip>("bgm");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound()
    {
        audioSource.PlayOneShot(backGroundMusic);
    }
}
