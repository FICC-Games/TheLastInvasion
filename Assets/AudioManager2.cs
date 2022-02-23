using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager2: MonoBehaviour {

    public Sound[] sounds;

    public static AudioManager2 instance;
    // Start is called before the first frame update
    void Awake () {

       //this line of code says that if the instance == to null then the track stops playing completely.
        if (instance == null)
            instance = this;
        else
        {
           //this line of code says that if the track doesnt get destroyed then it returns.
            Destroy(gameObject);
            return;
        }
        //this code makes it so the track doesnt get destroyed when it loads in the game.
        DontDestroyOnLoad(gameObject);
        
        foreach (Sound s in sounds)
        {
           //this code changes the volume strengh and the pitch of the track.
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.Clip;

           
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }   
    }

    private void Start()
    {
       //code that makes the game play the theme and not the fighting theme first.
        Play("Theme");
    }

    public void Play (string name)
    {
       //this code makes it so the game finds the correct track name taht it needs to play.
        Sound s = Array.Find(sounds, Sound => Sound.name == name);
        s.source.Play();
    }
    //made by marcus
}
