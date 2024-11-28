using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class HitPlayer : MonoBehaviour
{
    // Start is called before the first frame update
  
    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") ) {
           
            Debug.Log(collision.name);
        }
    }
}
