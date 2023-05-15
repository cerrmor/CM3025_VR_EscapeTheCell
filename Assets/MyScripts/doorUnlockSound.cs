using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorUnlockSound : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip doorUnlock;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.spatialBlend = 1;
        audioSource.volume = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playsound()
    {
        audioSource.PlayOneShot(doorUnlock);
    }
}
