using System.Collections.Generic;
using UnityEngine;

public abstract class PixelAttack : MonoBehaviour
{
    protected float currentTimeShot;
    protected bool canAttack = true;

    // オブジェクトとその寿命タイマーを保持するリスト
    private List<(GameObject obj, float timer)> currentObjects = new List<(GameObject, float)>();

    protected void StartAttack(AttackParameter attackParameter, PlayerParameter playerParameter)
    {
        if (canAttack)
        {
            SetParameter(attackParameter, playerParameter);
            GameObject newObject = Instantiate(attackParameter.attackObject, transform.position, transform.rotation);
            currentObjects.Add((newObject, 0f)); // 寿命タイマーを0で初期化してリストに追加
            PlaySound(attackParameter);
            canAttack = false;
        }
    }

    protected void UpdateAttack(AttackParameter attackParameter, PlayerParameter playerParameter)
    {
        PerformAttack();
        UpdateAndRemoveExpiredObjects(attackParameter);

        if (JudgeShot())
        {
            ResetShot();
            StartAttack(attackParameter, playerParameter);
        }
    }

    protected void PerformAttack()
    {
        currentTimeShot -= Time.deltaTime;

        // 各オブジェクトのタイマーを更新
        for (int i = 0; i < currentObjects.Count; i++)
        {
            currentObjects[i] = (currentObjects[i].obj, currentObjects[i].timer + Time.deltaTime);
        }
    }

    protected void UpdateAndRemoveExpiredObjects(AttackParameter attackParameter)
    {
        for (int i = currentObjects.Count - 1; i >= 0; i--)
        {
            var (obj, timer) = currentObjects[i];

            // 寿命を超えたオブジェクトを削除
            if (timer > attackParameter.deliteTime)
            {
                if (obj != null) Destroy(obj);
                currentObjects.RemoveAt(i);
            }
        }
    }
    protected bool JudgeShot()
    {
        return currentTimeShot < 0;
    }

    protected void ResetShot()
    {
        canAttack = true;
       
    }

    protected void SetParameter(AttackParameter attack, PlayerParameter player)
    {
        attack.Common_A.Attack = attack.damageRatio * player.Common_P.Attack;
        attack.Speed = attack.SpeedRatio * player.Speed;
        attack.deliteTime = attack.deliteTimeRatio * player.AttackTime;
        currentTimeShot = attack.shotTimeRatio;
    }

    protected void PlaySound(AttackParameter attack)
    {
        if (attack.bulletAudio != null)
        {
            attack.bulletAudio.PlayOneShot(attack.audioClip);
        }
    }
}
