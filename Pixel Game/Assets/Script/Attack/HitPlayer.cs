using UnityEngine;


public class HitPlayer : Damage
{
    [SerializeField] PlayerParameter player;
    [SerializeField] DamageManager damage;// プレイヤーのパラメーター
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
        // 無敵状態中はダメージを受けない
        if (!damage.Hit)
            return;

        if (collision.CompareTag("Enemy") && gameObject.tag==("Player"))
        {
            enemy = collision.GetComponent<EnemyParameter>();
            if (enemy != null)
            {
                if (player != null)
                {
                    // ダメージ処理
                    DamageEvent(player.Common_P, enemy.Common_E);
                    Debug.Log(gameObject.name);
                    // 無敵を開始
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
