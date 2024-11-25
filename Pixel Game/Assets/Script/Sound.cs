using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioClip audioClip;
    [SerializeField] string Audio;
   private AudioSource source;
    private const float PITCHUP=0.015f;
    private const float PITCHLIMIT = 2f;
    // Update is called once per frame

    public void PlaySound()
    {
        GameObject target = GameObject.Find(Audio);

        source = target.GetComponent<AudioSource>();
        PitchUp();
        source.PlayOneShot(audioClip);
        
    }
    public void PitchUp()//�G�邽�тɃs�b�`���グ��(����Ƃ����Čʂɒ������鎖�ł��Ȃ��̂�const�Ō��ߑł�)
    {
        if (source.pitch < PITCHLIMIT)
        {
            source.pitch += PITCHUP;
        }
    }
}
