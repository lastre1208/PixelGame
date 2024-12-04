using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class PixelAttack : MonoBehaviour//攻撃の共通処理。移動自体は他のスクリプトに
{
    // Start is called before the first frame update

   
   
    protected float currentTime;
    protected bool canAttack=true;
    private GameObject currentObject;
    // Update is called once per frame


    protected  void StartAttack(AttackParameter attackParameter,PlayerParameter playerParameter)//攻撃し始め
    {
        if (canAttack)
        {
            SetParameter(attackParameter, playerParameter);
            currentObject=Instantiate(attackParameter.attackObject, transform.position, transform.rotation);
            
            canAttack = false;
        }
    }
    protected void  UpdateAttack(AttackParameter attackParameter,PlayerParameter playerParameter)
    {
        PerformAttack();
        if (JudgeDelete(attackParameter))
        {
           if(currentObject != null)//敵にぶつかって寿命より先に死んでいる場合は時間経過で射出
            {
                EndAttack();
            }
            ResetTime();    
            StartAttack(attackParameter,playerParameter);
        }
    }
    protected  void PerformAttack()//攻撃中(寿命をカウント)
    {
        if (!canAttack)
        {
            currentTime += Time.deltaTime;
        }
       
    }
    protected  bool JudgeDelete(AttackParameter attackParameter)//寿命が尽きたか判断する
    {
        return currentTime > attackParameter.deliteTime ;
    }
    protected  void ResetTime()//時間リセット。再度攻撃ができるようになる
    {
        currentTime = 0;
        canAttack = true;
    }
    protected void EndAttack()//攻撃終了(敵にぶつかるか、寿命に達したら消去する)
    {
        Destroy(currentObject);
    }
    protected void SetParameter(AttackParameter attack, PlayerParameter player)//弾のパラメーターの算出
    {
        attack.Common_A.Attack = attack.damageRatio * player.Common_P.Attack;
        attack.Speed = attack.SpeedRatio * player.Speed;
        attack.deliteTime = attack.deliteTimeRatio * player.AttackTime;
     
       
    }
}
