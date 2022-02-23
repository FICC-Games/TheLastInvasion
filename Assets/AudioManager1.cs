using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager1 : MonoBehaviour
{
    public AudioClip defaultAmbience;
   
    private AudioSource track01, track02;
    private bool isPlayingTrack01;
    
    public static AudioManager1 instance;

    public void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        //This line of code makes it so the audio source1 and 2 plays if its true.
        track01 = gameObject.AddComponent<AudioSource>(); 
        track02 = gameObject.AddComponent<AudioSource>();
        isPlayingTrack01 = true;

        SwapTrack(defaultAmbience);
    }
    public void SwapTrack(AudioClip newClip)
    {
        //this line of code describes how if track 2 plays then track 1 stops playing and only track 2 is playing.
        if (isPlayingTrack01)
        {
            track02.clip = newClip;
            track02.Play();
            track01.Stop();
        }
        else
        {
           //this line of code describes if track 1 is playing then track 2 stops playing and only track 1 is playing.
            track01.clip = newClip;
            track01.Play();
            track02.Stop();
        }

        isPlayingTrack01 = isPlayingTrack01;

    }
    //this line of code makes it so when the player touches a certain zone the music track switches to another one.
    public void ReturnToDefault()
    {
        SwapTrack(defaultAmbience);
    }
    //made by marcus 
}


    
