// 無敵状態を管理するクラス
using UnityEngine;


public class HitPlayer : Damage
{
    [SerializeField] PlayerParameter player;  // プレイヤーのパラメーター
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
        // 無敵時間を更新（プレイヤー以外のオブジェクトも共有しているのでここでカウント）
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
        // 無敵状態中はダメージを受けない
        if (!Hit)
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
