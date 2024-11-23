using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AttackParameter
{//攻撃についているパラメーター。

    public GameObject target;//攻撃の起点。
    public GameObject attackObject;//攻撃そのもの。
    public float damageRatio;//攻撃倍率。
    public float deliteTimeRatio;//攻撃が消える時間の倍率。
    public float SpeedRatio;//攻撃の移動速度倍率。
    public bool canDelete;//敵にぶつかる等で消えるかどうか

}