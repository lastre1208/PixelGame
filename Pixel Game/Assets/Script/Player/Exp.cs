using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Exp : MonoBehaviour
{
    [SerializeField] PlayerParameter player;
    public float _exp;
    private void Awake()
    {
        player=GameObject.FindWithTag("P_Status").GetComponent<PlayerParameter>();
    }
    public void SetExp(EnemyParameter enemy,float exp)
    {
        _exp = enemy.Exp*exp*player.Exp_Rate;
    }
}
