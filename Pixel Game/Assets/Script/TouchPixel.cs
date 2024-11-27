using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TouchPixel : MonoBehaviour
{
    private Transform ParentObject;
    private BoxCollider2D boxCollider2D;
    public BoxCollider2D BoxCollider2D
    {
        get { return boxCollider2D; }
        set { boxCollider2D = value; }  
    }

   
    private Sound sound;
    LookPlayer lookPlayer;
   
    // Start is called before the first frame update
    void Start()
    {
       lookPlayer = GetComponent<LookPlayer>();
        ParentObject = transform.parent;
        BoxCollider2D = GetComponent<BoxCollider2D>();
        sound = GetComponent<Sound>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            ParentObject = collision.transform;
            transform.parent = ParentObject;
            gameObject.tag = ("Player");
            gameObject.layer = default;
            lookPlayer.Look();
            SetTrigger();
            sound.PlaySound();
        }
    }
    void SetTrigger()
    {
        BoxCollider2D.isTrigger= true;
    }
    
}
