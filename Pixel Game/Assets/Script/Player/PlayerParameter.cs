using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerParameter: MonoBehaviour,IUpgread
{
    [SerializeField] LevelUp levelUp;
    public CommonParameter Common_P;
    public float Exp;//�o���l
    public float Speed;//���x
    public float AttackTime;//�U���̎�������
    public float Lv;//���x��
    public float N_Lv;//���̃��x���ɕK�v�Ȍo���l
    public float Lv_Rate;
    public float SkillPoint;//�e�����ɗp����X�L���|�C���g
    public float GetSP;//�l���ł���X�L���|�C���g
    private void Update()
    {
        if (Exp > N_Lv)
        {
            while (Exp > N_Lv)
            {
                Lv++;
                N_Lv *= Lv_Rate;
                SkillPoint += GetSP;
                GetSP+=Lv;
            }
            Exp = 0;
            levelUp.OpenMenu();
        }
      
    }
    public float GetParameter(Lv_Type type)
    {
        return (type) switch
        {
            Lv_Type.HP => Common_P.maxHp,
            Lv_Type.Attack => Common_P.Attack,
            Lv_Type.Duration => AttackTime,
           Lv_Type.Exp=> Exp,
           Lv_Type.Speed => Speed,
           _=> throw new ArgumentOutOfRangeException(nameof(type),type,null),
        };
    }
    public void SetParameter(Lv_Type type, float value)
    {
        switch (type)
        {
            case Lv_Type.HP: Common_P.maxHp = value; break;
            case Lv_Type.Attack: Common_P.Attack = value; break;
            case Lv_Type.Duration: AttackTime = value; break;
            case Lv_Type.Exp: Exp = value; break;
            case Lv_Type.Speed: Speed = value; break;
        }
    }
}
