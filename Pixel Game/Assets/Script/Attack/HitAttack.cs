using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class HitAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]UnityEvent hitEvent;
    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") ) {
            hitEvent.Invoke();
            Debug.Log(gameObject.name);
        }
    }
}
