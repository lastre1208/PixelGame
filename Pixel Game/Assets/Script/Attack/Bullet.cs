using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : PixelAttack//弾を一定の間隔で放つスクリプト。
{
    // Start is called before the first frame update
  private AttackParameter attackParameter;
  private PlayerParameter playerParameter;
    [SerializeField] TouchPixel touch;
    [SerializeField] string Target;
    private bool Touched=false;
    // Update is called once per frame
    private void Start()
    {
     playerParameter   =  GameObject.Find("Pixel") .GetComponent<PlayerParameter>();
        attackParameter=GameObject.Find(Target) .GetComponent<AttackParameter>();
        
    }
    private void Update()
    {
        if (touch.BoxCollider2D.isTrigger&&!Touched)
        {
            StartAttack(attackParameter, playerParameter);//くっついた瞬間に一度だけ呼ぶ
            Touched = true;
         
        }

        UpdateAttack(attackParameter, playerParameter);
    }
   

}
