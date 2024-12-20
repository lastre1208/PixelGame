using UnityEngine;


public class HitPlayer : Damage
{
    [SerializeField] PlayerParameter player;
    [SerializeField] DamageManager damage;// �v���C���[�̃p�����[�^�[
    private EnemyParameter enemy;
  
    private void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("P_Status").GetComponent<PlayerParameter>();
            damage=GameObject.FindWithTag("Damage").GetComponent<DamageManager>();
        }
    }

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ���G��Ԓ��̓_���[�W���󂯂Ȃ�
        if (!damage.Hit)
            return;

        if (collision.CompareTag("Enemy") && gameObject.tag==("Player"))
        {
            enemy = collision.GetComponent<EnemyParameter>();
            if (enemy != null)
            {
                if (player != null)
                {
                    // �_���[�W����
                    DamageEvent(player.Common_P, enemy.Common_E);
                    Debug.Log(gameObject.name);
                    // ���G���J�n
                    damage.Hit = false;
                }
                else
                {
                    Debug.Log("Player not found");
                }
            }
            else
            {
                Debug.Log("Enemy parameter not found");
            }
        }
    }
}
