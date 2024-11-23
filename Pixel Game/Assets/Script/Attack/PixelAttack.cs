using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class PixelAttack : MonoBehaviour//攻撃の共通処理。移動自体は他のスクリプトに
{
    // Start is called before the first frame update

   
   
    protected float currentTime;
    protected bool canAttack=true;
    // Update is called once per frame


    protected virtual void StartAttack(AttackParameter attackParameter)//攻撃し始め
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
           if(attackParameter.attackObject != null)//敵にぶつかって寿命より先に死んでいる場合は時間経過で射出
            {
                EndAttack(attackParameter);
            }
            ResetTime();    
            StartAttack(attackParameter);
        }
    }
    protected virtual void PerformAttack()//攻撃中(寿命をカウント)
    {
        if (!canAttack)
        {
            currentTime += Time.deltaTime;
        }
       
    }
    protected virtual bool JudgeDelete(AttackParameter attackParameter)//寿命が尽きたか判断する
    {
        return (currentTime > attackParameter.deliteTimeRatio ? true : false);
    }
    protected virtual void ResetTime()//時間リセット。再度攻撃ができるようになる
    {
        currentTime = 0;
        canAttack = true;
    }
    protected virtual void EndAttack(AttackParameter attackParameter)//攻撃終了(敵にぶつかるか、寿命に達したら消去する)
    {
        Destroy(attackParameter.attackObject);
    }
    
}
