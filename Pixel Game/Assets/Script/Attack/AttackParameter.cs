using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackParameter : MonoBehaviour, IUpgread
{//�U���ɂ��Ă���p�����[�^�[�B


    public GameObject attackObject;//�U�����̂��́B
    public int LV;//�e�̃��x���B
    public float damageRatio;//�U���{���B
    [HideInInspector]
    //�v���C���[�̍U���͂ƍ��킳���Ď��ۂɋ��߂���U����
    public CommonParameter Common_A;
    public float deliteTimeRatio;//�U���������鎞�Ԃ̔{���B
    [HideInInspector]
    public float deliteTime;//�v���C���[�̃p�����[�^�[�ƍ��킳���Ď��ۂɋ��߂��鎞��
    
  
   public float shotTimeRatio;

    public float SpeedRatio;//�U���̈ړ����x�{���B
    [HideInInspector]
    public float Speed;//��ɓ����I
    public bool canDelete;//�G�ɂԂ��铙�ŏ����邩�ǂ���
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