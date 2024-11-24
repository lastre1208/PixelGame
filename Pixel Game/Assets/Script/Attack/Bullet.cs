using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : PixelAttack//弾を一定の間隔で放つスクリプト。
{
    // Start is called before the first frame update
    public AttackParameter attackParameter;
  
    [SerializeField] TouchPixel touch;
    private bool Touched=false;
    // Update is called once per frame
    private void Update()
    {
        if (touch.BoxCollider2D.isTrigger&&!Touched)
        {
            StartAttack(attackParameter);//くっついた瞬間に一度だけ呼ぶ
            Touched = true;
        }

        UpdateAttack(attackParameter);
    }
   

}
