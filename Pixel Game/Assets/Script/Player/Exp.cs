using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Exp : MonoBehaviour
{
    public float _exp;

    public void SetExp(EnemyParameter enemy,float exp)
    {
        _exp = enemy.Exp*exp;
    }
}
