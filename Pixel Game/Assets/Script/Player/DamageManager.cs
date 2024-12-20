using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
   [SerializeField] PlayerParameter player;
    private bool hit;

    public bool Hit
    {
        get { return hit; }
        set { hit = value; }    
    }
    float Hitcount;
   
    void Update()
    {
       
            // ���G���Ԃ��X�V�i�v���C���[�ȊO�̃I�u�W�F�N�g�����L���Ă���̂ł����ŃJ�E���g�j
            if (!Hit)
            {
                Hitcount += Time.deltaTime;
                if (Hitcount > player.DamageTime)
                {
                    Hit = true;
                    Hitcount = 0;
                }
            }
        
    }
}
