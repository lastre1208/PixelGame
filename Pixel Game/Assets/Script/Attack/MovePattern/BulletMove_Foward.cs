using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove_Foward : MonoBehaviour
{
    // Start is called before the first frame update

    
    private AttackParameter bullet;
    public AttackParameter Bullet
    {
        get { return bullet; }
        set { bullet = value; }
    }
    [SerializeField] string Target;
    [SerializeField] bool Moving;
    private void Start()
    {
        Bullet= GameObject.Find(Target).GetComponent<AttackParameter>();
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Moving)
        {
            this.transform.position += Bullet.Speed * transform.up * Time.deltaTime;
        }
    }
}
