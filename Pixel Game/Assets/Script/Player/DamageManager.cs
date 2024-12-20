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
       
            // 無敵時間を更新（プレイヤー以外のオブジェクトも共有しているのでここでカウント）
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
