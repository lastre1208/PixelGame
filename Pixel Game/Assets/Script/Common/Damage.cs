using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public abstract class Damage : MonoBehaviour//enemy=攻撃を受ける側、attack=攻撃する側
{

   
   protected bool DamageEvent(CommonParameter enemy,CommonParameter attack)
    {
        SetDamage(enemy,attack);
        
        if (enemy.Hp < 0)
        { 
            return true;
        }
        else
        {
            return false;
        }
    }
    protected float GetDamage(CommonParameter attack)//ダメージ計算。
    {
        return attack.Attack;
    }
    protected void SetDamage(CommonParameter enemy, CommonParameter attack)//計算されたダメージを付与
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
   
   
}
