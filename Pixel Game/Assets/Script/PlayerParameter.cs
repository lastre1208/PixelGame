using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;


public class PlayerParameter: MonoBehaviour
{
    public CommonParameter Common_P;
    public float Exp;//�o���l
    public float Speed;//���x
    public float AttackTime;//�U���̎�������
    public float Lv;//���x��
    public float N_Lv;//���̃��x���ɕK�v�Ȍo���l
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
