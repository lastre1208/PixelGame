using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DefeatSound :MonoBehaviour
{
     AudioSource _audio;
    public AudioClip _audioClip;
   
    public  void Start()
    {
        _audio = GetComponent<AudioSource>();
        _audio.PlayOneShot(_audioClip);
        
    }
   
}
