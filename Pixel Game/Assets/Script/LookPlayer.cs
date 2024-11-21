using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LookPlayer : MonoBehaviour
{
    private GameObject target;
    private Transform target_t;
    // Start is called before the first frame update
    private void Start()
    {
        target = GameObject.Find("Pixel");
        target_t = target.transform;
    }

    // Update is called once per frame
    public void Look()
    {
       Vector3 dir=target_t.transform.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up,dir);
        transform.Rotate(0, 0, 180);
    }
}
