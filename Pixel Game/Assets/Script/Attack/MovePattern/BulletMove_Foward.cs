using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove_Foward : MonoBehaviour
{
    // Start is called before the first frame update

    
    private AttackParameter bullet;
    [SerializeField] string Target;
    private void Start()
    {
        bullet= GameObject.Find(Target).GetComponent<AttackParameter>();
        
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.position+= bullet.Speed* transform.up*Time.deltaTime;

    }
}
