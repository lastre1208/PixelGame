using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZag : MonoBehaviour
{
    // Start is called before the first frame update
   
    [SerializeField] float length;
    [SerializeField] float zigzagSpeed;
    [SerializeField] float Move_X=0.02f;
    private float count;
    private Vector2 start;
    private bool Zigzag = false;
    // Update is called once per frame
    private void Start()
    {
        Vector2 start= transform.position;
    }
    void Update()
    {
        transform.Translate(Move_X, 0, 0);
        count += zigzagSpeed*Time.deltaTime;
        if (Move_X < 0)
        {
            {
                if (count > length * 2)
                {
                    Move_X *= -1;
                    count = 0;
                }
            }
        }
        else if (Move_X > 0)
        {
            if (count > length && !Zigzag)
            {
                Move_X *= -1;
                count = 0;
                Zigzag = true;
            }
            else if (count > length * 2)
            {
                Move_X *= -1;
                count = 0;
            }
        }
        
    }
}
