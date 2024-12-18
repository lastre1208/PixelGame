using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CommonParameter 
{
    public float maxHp;
    private float hp;
    public float Hp
    {
        get { return hp; }
        set
        {
            if (value > maxHp)
            {
                hp = maxHp;
            }
            else
            {
                hp = value;
            }
            
        }
    }
    public float Attack;
}
