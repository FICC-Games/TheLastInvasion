using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwap : MonoBehaviour
{
    public AudioClip newTrack;

    private void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager1.instance.SwapTrack(newTrack);
            
        }
           
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager1.instance.ReturnToDefault(); 
        }
    }
}


