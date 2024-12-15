using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class HitEnemy : Damage
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip _audio;
    [SerializeField] GameObject _effect;
    [SerializeField] GameObject _Exp;
    [SerializeField] string _UIname;
    DamageDisplay _display;
    private EnemyParameter EnemyParameter;
    private BulletMove_Foward AttackParameter;
    private GameObject exp_Prefab;
    private GameObject lastCollision;
    private float Hitcount;
    private bool Hit = true;
    // Update is called once per frame
    private void Start()
    {
        _display = GameObject.FindWithTag(_UIname).GetComponent<DamageDisplay>();
    }

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
            if (DamageEvent(EnemyParameter.Common_E, AttackParameter.Bullet.Common_A))
            {
                _display.DisplayDamage(EnemyParameter, AttackParameter.Bullet.Common_A);
                PlayDeath();
                Destroy(gameObject);
            }
            else
            {
                PlayHit();
            }
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
    public void PlayHit()
    {
        audioSource.PlayOneShot(_audio);
    }
     void PlayDeath()
    {
        DropExp();
        Instantiate(_effect, this.gameObject.transform.position, Quaternion.Euler(-90, 0, 0));
        Debug.Log("うわああああ");
    }
    void DropExp()
    {
     exp_Prefab=   Instantiate(_Exp, this.gameObject.transform.position, Quaternion.identity);
       Exp expCompornent= exp_Prefab.GetComponent<Exp>();
        expCompornent.SetExp(EnemyParameter,expCompornent._exp);
        Debug.Log(expCompornent._exp);
    }
}
