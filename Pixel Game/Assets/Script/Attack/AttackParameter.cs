using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackParameter:MonoBehaviour
{//�U���ɂ��Ă���p�����[�^�[�B

   
    public GameObject attackObject;//�U�����̂��́B
    public float damageRatio;//�U���{���B
    [HideInInspector]
    public float damage;//�v���C���[�̍U���͂ƍ��킳���Ď��ۂɋ��߂���U����
    public  float deliteTimeRatio;//�U���������鎞�Ԃ̔{���B
    [HideInInspector]
    public float deliteTime;//�v���C���[�̃p�����[�^�[�ƍ��킳���Ď��ۂɋ��߂��鎞��
    public  float SpeedRatio;//�U���̈ړ����x�{���B
    [HideInInspector] 
    public float Speed;//��ɓ����I
    public bool canDelete;//�G�ɂԂ��铙�ŏ����邩�ǂ���

}