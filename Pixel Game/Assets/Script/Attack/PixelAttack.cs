using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackParameter
{
    public GameObject target;
    public GameObject attackObject;
    public float damage;
    public float deliteTime;
    public float Lv;
   public float moveSpeed;
  public  bool canDelete;
    
}
public abstract class PixelAttack : MonoBehaviour//攻撃の共通処理。移動自体は他のスクリプトに
{
    // Start is called before the first frame update
   
    [SerializeField] AttackParameter attackParameter;
    protected float currentTime;
    protected bool canAttack;
    // Update is called once per frame


    protected virtual void StartAttack(AttackParameter attackParameter)//攻撃し始め
    {
        if (canAttack)
        {
            Instantiate(attackParameter.attackObject, transform.position, transform.rotation);
            canAttack = false;
        }
    }
    protected virtual void PerformAttack()//攻撃中(寿命をカウント)
    {
        currentTime += Time.deltaTime;
    }
    protected virtual bool JudgeDelete(AttackParameter attackParameter)//寿命が尽きたか判断する
    {
        return (currentTime > attackParameter.deliteTime ? true : false);
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
