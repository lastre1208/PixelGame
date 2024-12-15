using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public abstract class Damage : MonoBehaviour//enemy=�U�����󂯂鑤�Aattack=�U�����鑤
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
    protected float GetDamage(CommonParameter attack)//�_���[�W�v�Z�B
    {
        return attack.Attack;
    }
    protected void SetDamage(CommonParameter enemy, CommonParameter attack)//�v�Z���ꂽ�_���[�W��t�^
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
