using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class PixelAttack : MonoBehaviour//�U���̋��ʏ����B�ړ����̂͑��̃X�N���v�g��
{
    // Start is called before the first frame update

   
   
    protected float currentTime;
    protected bool canAttack=true;
    // Update is called once per frame


    protected virtual void StartAttack(AttackParameter attackParameter)//�U�����n��
    {
        if (canAttack)
        {
            Instantiate(attackParameter.attackObject, transform.position, transform.rotation);
            canAttack = false;
        }
    }
    protected virtual void  UpdateAttack(AttackParameter attackParameter)
    {
        PerformAttack();
        if (JudgeDelete(attackParameter))
        {
           if(attackParameter.attackObject != null)//�G�ɂԂ����Ď�������Ɏ���ł���ꍇ�͎��Ԍo�߂Ŏˏo
            {
                EndAttack(attackParameter);
            }
            ResetTime();    
            StartAttack(attackParameter);
        }
    }
    protected virtual void PerformAttack()//�U����(�������J�E���g)
    {
        if (!canAttack)
        {
            currentTime += Time.deltaTime;
        }
       
    }
    protected virtual bool JudgeDelete(AttackParameter attackParameter)//�������s���������f����
    {
        return (currentTime > attackParameter.deliteTimeRatio ? true : false);
    }
    protected virtual void ResetTime()//���ԃ��Z�b�g�B�ēx�U�����ł���悤�ɂȂ�
    {
        currentTime = 0;
        canAttack = true;
    }
    protected virtual void EndAttack(AttackParameter attackParameter)//�U���I��(�G�ɂԂ��邩�A�����ɒB�������������)
    {
        Destroy(attackParameter.attackObject);
    }
    
}
