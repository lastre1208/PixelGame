using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : PixelAttack//�e�����̊Ԋu�ŕ��X�N���v�g�B
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
            StartAttack(attackParameter);//���������u�ԂɈ�x�����Ă�
            Touched = true;
        }

        UpdateAttack(attackParameter);
    }
   

}
