using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AttackParameter
{//�U���ɂ��Ă���p�����[�^�[�B

    public GameObject target;//�U���̋N�_�B
    public GameObject attackObject;//�U�����̂��́B
    public float damageRatio;//�U���{���B
    public float deliteTimeRatio;//�U���������鎞�Ԃ̔{���B
    public float SpeedRatio;//�U���̈ړ����x�{���B
    public bool canDelete;//�G�ɂԂ��铙�ŏ����邩�ǂ���

}