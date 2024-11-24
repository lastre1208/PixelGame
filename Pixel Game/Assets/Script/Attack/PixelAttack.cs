using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class PixelAttack : MonoBehaviour//�U���̋��ʏ����B�ړ����̂͑��̃X�N���v�g��
{
    // Start is called before the first frame update

   
   
    protected float currentTime;
    protected bool canAttack=true;
    private GameObject currentObject;
    // Update is called once per frame


    protected  void StartAttack(AttackParameter attackParameter)//�U�����n��
    {
        if (canAttack)
        {
            currentObject=Instantiate(attackParameter.attackObject, transform.position, transform.rotation);
            canAttack = false;
        }
    }
    protected void  UpdateAttack(AttackParameter attackParameter)
    {
        PerformAttack();
        if (JudgeDelete(attackParameter))
        {
           if(currentObject != null)//�G�ɂԂ����Ď�������Ɏ���ł���ꍇ�͎��Ԍo�߂Ŏˏo
            {
                EndAttack();
            }
            ResetTime();    
            StartAttack(attackParameter);
        }
    }
    protected  void PerformAttack()//�U����(�������J�E���g)
    {
        if (!canAttack)
        {
            currentTime += Time.deltaTime;
        }
       
    }
    protected  bool JudgeDelete(AttackParameter attackParameter)//�������s���������f����
    {
        return currentTime > attackParameter.deliteTimeRatio ;
    }
    protected  void ResetTime()//���ԃ��Z�b�g�B�ēx�U�����ł���悤�ɂȂ�
    {
        currentTime = 0;
        canAttack = true;
    }
    protected void EndAttack()//�U���I��(�G�ɂԂ��邩�A�����ɒB�������������)
    {
        Destroy(currentObject);
    }
    
}
