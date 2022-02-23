using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwap : MonoBehaviour
{
   //this line of code makes it so the audioclip that is selected plays a new track 
    public AudioClip newTrack;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //this line of code makes it so when the player collides with a certain area it swaps tracks.
        if (other.CompareTag("Player"))
        {
            AudioManager1.instance.SwapTrack(newTrack);
                
        }
           
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        //this line of code makes it so when the player goes out of the certain arean it return to the original soundtrack.
        if (other.CompareTag("Player"))
        {
            AudioManager1.instance.ReturnToDefault(); 
        }
    }
    //made by marcus
}


