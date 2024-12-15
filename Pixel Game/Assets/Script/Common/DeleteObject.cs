using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float deleteTime;
   
    private float count;
    // Update is called once per frame
    void Update()
    {
        count +=Time.deltaTime;
        if(count > deleteTime)
        {
            Destroy(this.gameObject);
           
        }
    }
}
