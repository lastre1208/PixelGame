using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class HitEnemy : MonoBehaviour
{
    [SerializeField] UnityEvent HitEvent;



    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag==("Player")&&collision.CompareTag("Enemy"))
        {
            HitEvent.Invoke();
            Debug.Log(gameObject.name);
        }
    }
}
