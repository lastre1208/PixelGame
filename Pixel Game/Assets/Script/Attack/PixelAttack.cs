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
public abstract class PixelAttack : MonoBehaviour//�U���̋��ʏ����B�ړ����̂͑��̃X�N���v�g��
{
    // Start is called before the first frame update
   
    [SerializeField] AttackParameter attackParameter;
    protected float currentTime;
    protected bool canAttack;
    // Update is called once per frame


    protected virtual void StartAttack(AttackParameter attackParameter)//�U�����n��
    {
        if (canAttack)
        {
            Instantiate(attackParameter.attackObject, transform.position, transform.rotation);
            canAttack = false;
        }
    }
    protected virtual void PerformAttack()//�U����(�������J�E���g)
    {
        currentTime += Time.deltaTime;
    }
    protected virtual bool JudgeDelete(AttackParameter attackParameter)//�������s���������f����
    {
        return (currentTime > attackParameter.deliteTime ? true : false);
    }
    protected virtual void ResetTime()//���ԃ��Z�b�g�B�ēx�U�����ł���悤�ɂȂ�
    {
        currentTime = 0;
        canAttack = true;
    }
    protected virtual void EndAttack(AttackParameter attackParameter)//�U���I��(�G�ɂԂ��邩�A�����ɒB�������������)
    {
        Destroy(attackParameter.attackObject);
    }
    
}
