using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLaser : MonoBehaviour
{
    // Start is called before the first frame update
  
    [SerializeField] GameObject target;
   
    // Update is called once per frame

    private LineRenderer lineRenderer;
 
    private void Start()
    {
       
        lineRenderer=GetComponent<LineRenderer>();
      Vector3 start=target.transform.position;
        lineRenderer.SetPosition(1,transform.position);
        lineRenderer.SetPosition(0, transform.position);
    }
    void Update()
    {
        lineRenderer.SetPosition(0, transform.position);
    }
}