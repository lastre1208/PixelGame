using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Damage : MonoBehaviour
{
   protected void DamageEvent(EnemyParameter enemy,AttackParameter attack)
    {
        SetDamage(enemy,attack);
        if (enemy.Hp < 0)
        {
            Death();
        }
    }
    protected float GetDamage(AttackParameter attack)//ダメージ計算。
    {
        return attack.damage;
    }
    protected void SetDamage(EnemyParameter enemy, AttackParameter attack)//計算されたダメージを付与
    {
        if (enemy == null)
        {
            Debug.Log("aaaa");
        }
        else if (attack == null)
        {
            Debug.Log("qqq");

        }
        else
        {
            enemy.Hp -= GetDamage(attack);
        }
    }
   protected void Death()//ダメージによる死亡処理
    {
        Destroy(gameObject);
        Debug.Log("うわああああ");
    }
      
}
