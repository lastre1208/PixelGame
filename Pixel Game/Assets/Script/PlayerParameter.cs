using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;


public class PlayerParameter: MonoBehaviour
{
    public CommonParameter Common_P;
    public float Exp;//経験値
    public float Speed;//速度
    public float AttackTime;//攻撃の持続時間
    public float Lv;//レベル
    public float N_Lv;//次のレベルに必要な経験値
    public float Lv_Rate;
    private void Update()
    {
        if (Exp > N_Lv)
        {
            while (Exp > N_Lv)
            {
                Lv++;
                N_Lv *= Lv_Rate;
            }
            Exp = 0;
        }
      
    }
}
