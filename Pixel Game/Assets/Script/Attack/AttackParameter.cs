using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackParameter : MonoBehaviour, IUpgread
{//UŒ‚‚É‚Â‚¢‚Ä‚¢‚éƒpƒ‰ƒ[ƒ^[B


    public GameObject attackObject;//UŒ‚‚»‚Ì‚à‚ÌB
    public int LV;//’e‚ÌƒŒƒxƒ‹B
    public float damageRatio;//UŒ‚”{—¦B
    [HideInInspector]
    //ƒvƒŒƒCƒ„[‚ÌUŒ‚—Í‚Æ‡‚í‚³‚Á‚ÄŽÀÛ‚É‹‚ß‚ç‚ê‚éUŒ‚—Í
    public CommonParameter Common_A;
    public float deliteTimeRatio;//UŒ‚‚ªÁ‚¦‚éŽžŠÔ‚Ì”{—¦B
    [HideInInspector]
    public float deliteTime;//ƒvƒŒƒCƒ„[‚Ìƒpƒ‰ƒ[ƒ^[‚Æ‡‚í‚³‚Á‚ÄŽÀÛ‚É‹‚ß‚ç‚ê‚éŽžŠÔ
    
  
   public float shotTimeRatio;

    public float SpeedRatio;//UŒ‚‚ÌˆÚ“®‘¬“x”{—¦B
    [HideInInspector]
    public float Speed;//ã‚É“¯‚¶I
    public bool canDelete;//“G‚É‚Ô‚Â‚©‚é“™‚ÅÁ‚¦‚é‚©‚Ç‚¤‚©
    public AudioSource bulletAudio;
    public AudioClip audioClip;

    public float GetParameter(Lv_Type type)
    {
        return (type) switch
        {
            Lv_Type.Weapon_Attack => damageRatio,
            Lv_Type.Weapon_Duration => deliteTimeRatio,
            Lv_Type.Weapon_Speed => SpeedRatio,
            Lv_Type.Weapon_Shot => shotTimeRatio,
            _ => throw new ArgumentOutOfRangeException(nameof(type), type,null)

        };
    }
    public void SetParameter(Lv_Type type,float value)
    {
        switch (type)
        {
            case Lv_Type.Weapon_Attack: damageRatio = value; break;
            case Lv_Type.Weapon_Duration: deliteTimeRatio = value; break;
            case Lv_Type.Weapon_Speed: SpeedRatio = value; break;
            case Lv_Type.Weapon_Shot: shotTimeRatio = value; break;
        }
    }
}