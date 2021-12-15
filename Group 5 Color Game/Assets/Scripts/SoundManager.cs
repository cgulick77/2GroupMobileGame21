using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource pastAudio, futureAudio;
    public ClockTool clockToolScript;
    
    void Start()
    {
        clockToolScript = FindObjectOfType<ClockTool>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clockToolScript.past)
        {
            pastAudio.enabled = true;
            futureAudio.enabled = false;
        }
        else 
        {
            pastAudio.enabled = false;
            futureAudio.enabled = true;
        }
    }

   
}
