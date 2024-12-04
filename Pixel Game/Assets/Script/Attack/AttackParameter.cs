using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackParameter:MonoBehaviour
{//攻撃についているパラメーター。

   
    public GameObject attackObject;//攻撃そのもの。
    public float damageRatio;//攻撃倍率。
    [HideInInspector]
    public float damage;//プレイヤーの攻撃力と合わさって実際に求められる攻撃力
    public  float deliteTimeRatio;//攻撃が消える時間の倍率。
    [HideInInspector]
    public float deliteTime;//プレイヤーのパラメーターと合わさって実際に求められる時間
    public  float SpeedRatio;//攻撃の移動速度倍率。
    [HideInInspector] 
    public float Speed;//上に同じ！
    public bool canDelete;//敵にぶつかる等で消えるかどうか

}