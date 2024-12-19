using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PixelDisplay : MonoBehaviour
{

    [SerializeField] TMP_Text pixel;
    private int count;

    // Update is called once per frame
    void Update()
    { 
        pixel.text = count.ToString() + "Pixels!!";
    }
   public  void PixelCount()
    {
        GameObject[]objects   = GameObject.FindGameObjectsWithTag("Player");
        count = objects.Length;
    }
}
