using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSoundManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public static SkinSoundManager sondman;

    void Start()
    {
        sondman = this;
        source = GetComponent<AudioSource>();
        
    }
    // Update is called once per frame
    public void PlayBasketSound()
    {
        source.PlayOneShot(clip);
    }
    public void PlayEggSound()
    {
        source.PlayOneShot(clip);
    }
    public void PlayGasSound()
    {
        source.PlayOneShot(clip);
    }
    public void PlayDefaultSound()
    {
        source.PlayOneShot(clip);
    }
}
