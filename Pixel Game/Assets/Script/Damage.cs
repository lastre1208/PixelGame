using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public abstract class Damage : MonoBehaviour
{

    [SerializeField] GameObject _defeatObject;
    private GameObject _defeatPrefab;
   protected void DamageEvent(EnemyParameter enemy,AttackParameter attack)
    {
        SetDamage(enemy,attack);
        if (enemy.Hp < 0)
        {
            Death();
        }
    }
    protected float GetDamage(AttackParameter attack)//�_���[�W�v�Z�B
    {
        return attack.damage;
    }
    protected void SetDamage(EnemyParameter enemy, AttackParameter attack)//�v�Z���ꂽ�_���[�W��t�^
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
   protected void Death()//�_���[�W�ɂ�鎀�S����
    {
        PlayDeath();
        Destroy(gameObject);
        Debug.Log("���킠������");
    }
     protected void PlayDeath()
    {

        _defeatPrefab = Instantiate(_defeatObject, this.gameObject.transform.position, Quaternion.Euler(-90, 0, 0));
       Debug.Log(_defeatPrefab.name);
    } 
}
