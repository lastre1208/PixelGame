using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackParameter
{
     GameObject attackObject;
    float damage;
    float deliteTime;
    float Lv;
    float moveSpeed;
    bool canDelete;
    
}
public abstract class PixelAttack : MonoBehaviour
{
    // Start is called before the first frame update
   
    [SerializeField]AttackParameter attackParameter;
    // Update is called once per frame

    public void Attack()
    {
        StartAttack();
        PerformAttack();
    }
   protected virtual void  StartAttack()//çUåÇÇµénÇﬂ
    {

    }
    protected virtual void PerformAttack()
    {

    }
}
