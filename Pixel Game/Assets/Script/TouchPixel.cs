using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPixel : MonoBehaviour
{
    private Transform ParentObject;
    private BoxCollider2D boxCollider2D;
    LookPlayer lookPlayer;
    public float snapDistance = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
       lookPlayer = GetComponent<LookPlayer>();
        ParentObject = transform.parent;
        boxCollider2D = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    if (collision.gameObject.CompareTag("Player")) {
            ParentObject = collision.transform;
            transform.parent = ParentObject;
            gameObject.tag = ("Player");
            lookPlayer.Look();
                  SetTrigger();
        }
    }
    void SetTrigger()
    {
        boxCollider2D.isTrigger= true;
    }
    
}
