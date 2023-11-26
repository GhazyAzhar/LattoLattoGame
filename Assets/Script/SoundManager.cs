using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager sondman;
    private AudioSource audioSrc;
    private AudioClip[] popSounds;
    private AudioClip basketSounds;
    private int randomPopSound;

    // Start is called before the first frame update
    void Start()
    {
        sondman = this;
        audioSrc = GetComponent<AudioSource>();
        popSounds = Resources.LoadAll<AudioClip>("Defaultskinsfx");
    }

  
    public void PlayPopSound()
    {
        randomPopSound = Random.Range(0, 3);
        audioSrc.PlayOneShot(popSounds[randomPopSound]);
        Debug.Log(9999955555);
    }
    
}
