using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class HitEnemy : Damage
{

   
    private EnemyParameter EnemyParameter;
    private BulletMove_Foward AttackParameter;
    private GameObject lastCollision;
    private float Hitcount;
    private bool Hit = true;
    // Update is called once per frame

    private void Update()
    {
        if (!Hit)
        {
            Hitcount += Time.deltaTime;
            if (Hitcount > EnemyParameter.DamageTime)
            {
                Hit = true;
                Hitcount = 0;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == ("Enemy") && collision.CompareTag("Bullet")&&Hit)
        {
           AttackParameter = HitReturn(collision).GetComponent<BulletMove_Foward>();//弾のコンポーネントを取得
            if(AttackParameter == null) {
                Debug.Log(collision.gameObject);
            }
            EnemyParameter = this.GetComponent<EnemyParameter>();
            Hit = false ;
            E_Damage();
           Delete();
           
        }
    }
    public void E_Damage()
    {
        if (EnemyParameter == null)
        {
            Debug.Log("eerr");
        }
        else if (AttackParameter == null)
        {
            Debug.Log("oooo");
        }
        else
        {
            DamageEvent(EnemyParameter, AttackParameter.Bullet);
        }
      
    }
    public GameObject HitReturn(Collider2D collision)
    {
        lastCollision = collision.gameObject;
        return lastCollision;
    }
    public void Delete()//当たった時弾のオブジェクトを消す
    {
        if (AttackParameter != null)
        {
            if (AttackParameter.Bullet.canDelete)
            {
                Destroy(AttackParameter.gameObject);
            }
        }
    }
}
