using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerParameter: MonoBehaviour,IUpgread
{
    [SerializeField] LevelUp levelUp;
    public CommonParameter Common_P;
    public float Exp;//経験値
    public float Speed;//速度
    public float AttackTime;//攻撃の持続時間
    public float Lv;//レベル
    public float N_Lv;//次のレベルに必要な経験値
    public float Lv_Rate;
    public float SkillPoint;//各強化に用いるスキルポイント
    public float GetSP;//獲得できるスキルポイント
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
