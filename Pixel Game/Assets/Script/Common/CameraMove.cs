using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform target;    
    

    // Update is called once per frame
    void Update()
    {
        transform.position=new(target.position.x,target.position.y,transform.position.z);

    }
}
