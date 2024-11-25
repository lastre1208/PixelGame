using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioClip audioClip;
    [SerializeField] string Audio;
   private AudioSource source;
    // Update is called once per frame

    public void PlaySound()
    {
        GameObject target = GameObject.Find(Audio);
        if (target != null)
        {
            source = target.GetComponent<AudioSource>();
            source.PlayOneShot(audioClip);
        }
    }
}
