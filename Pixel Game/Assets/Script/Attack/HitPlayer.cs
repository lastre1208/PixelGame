// ���G��Ԃ��Ǘ�����N���X
using UnityEngine;


public class HitPlayer : Damage
{
    [SerializeField] PlayerParameter player;  // �v���C���[�̃p�����[�^�[
    private EnemyParameter enemy;
    private float Hitcount;
    private bool Hit=true;
    private void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("P_Status").GetComponent<PlayerParameter>();
        }
    }

    private void Update()
    {
        // ���G���Ԃ��X�V�i�v���C���[�ȊO�̃I�u�W�F�N�g�����L���Ă���̂ł����ŃJ�E���g�j
        if (!Hit)
        {
            Hitcount += Time.deltaTime;
            if (Hitcount > player.DamageTime)
            {
                Hit = true;
                Hitcount = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ���G��Ԓ��̓_���[�W���󂯂Ȃ�
        if (!Hit)
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
                    Hit= false;
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
