using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletRotate : MonoBehaviour
{
    // Start is called before the first frame update
   
    [SerializeField] float Speed;
    private int Direction;
    private void Start()
    {
        Direction = (0 < Random.Range(0, 2) ? 1 : -1);
    }

    void Update()
    {
        transform.Rotate(0, 0, Speed* Time.deltaTime*Direction);
    }
}
