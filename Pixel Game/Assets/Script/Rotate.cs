using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotate : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    private int rotationDirection;
    // Start is called before the first frame update

    public void OnRotate(InputAction.CallbackContext context)
    {

        float input = context.ReadValue<float>();
        if (input < 0)
        {
            rotationDirection = 1;
        }
        else if (input > 0)
        {
            rotationDirection = -1;
        }
        else
        {
            rotationDirection = 0;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, rotateSpeed*rotationDirection*Time.deltaTime);
    }
}
