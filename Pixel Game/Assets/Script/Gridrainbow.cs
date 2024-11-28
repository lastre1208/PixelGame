using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGradation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]SpriteRenderer Sprite;
    [SerializeField] float Speed;

    // Update is called once per frame
    void Update()
    {
        float hue = (Time.time * Speed) % 1;
        Sprite.color = Color.HSVToRGB(hue, 1, 1);
    }
}
