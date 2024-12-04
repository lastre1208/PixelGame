using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : PixelAttack//�e�����̊Ԋu�ŕ��X�N���v�g�B
{
    // Start is called before the first frame update
 private AttackParameter attackParameter;
    public AttackParameter AttackParameter
    {
        get { return attackParameter; }
        set { attackParameter = value; }
    }
   private PlayerParameter playerParameter;
    public PlayerParameter PlayerParameter
    {
        get { return playerParameter; }
        set { playerParameter = value; }
    }
    [SerializeField] TouchPixel touch;
    [SerializeField] string Target;
    private bool Touched=false;
    // Update is called once per frame
    private void Start()
    {
     PlayerParameter   =  GameObject.FindWithTag("P_Status") .GetComponent<PlayerParameter>();
        AttackParameter=GameObject.Find(Target) .GetComponent<AttackParameter>();
        
    }
    private void Update()
    {
        if (touch.BoxCollider2D.isTrigger&&!Touched)
        {
            StartAttack(AttackParameter, PlayerParameter);//���������u�ԂɈ�x�����Ă�
            Touched = true;
         
        }

        UpdateAttack(AttackParameter, PlayerParameter);
    }
   

}
