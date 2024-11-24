using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove_Foward : MonoBehaviour
{
    // Start is called before the first frame update

    
    [SerializeField] Bullet bullet;
    // Update is called once per frame
    void Update()
    {
        this.transform.position+=( bullet.attackParameter.SpeedRatio* transform.up*Time.deltaTime);
    }
}
