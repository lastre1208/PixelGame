using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletRotate_N : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Bullet bullet;
    [SerializeField] float Speed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, bullet.attackParameter.SpeedRatio*Speed* Time.deltaTime);
    }
}
