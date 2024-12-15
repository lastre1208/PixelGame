using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;


public class DamageDisplay : MonoBehaviour
{
    [SerializeField] GameObject _text;
    [SerializeField]Transform _canvas;
    [SerializeField]Gradient _gradient;
    [SerializeField] TMP_Text text;
    [SerializeField]float Max;
    [SerializeField]float Min;  
    // Start is called before the first frame update
    void Start()
    {
        TMP_Text text=_text.GetComponent<TMP_Text>();
      
    }

    // Update is called once per frame
public void DisplayDamage(EnemyParameter enemy,CommonParameter attack)
    {
        Vector3 Screen = Camera.main.WorldToScreenPoint(enemy.transform.position);

        Instantiate(_text,Screen,Quaternion.identity,_canvas);
        
           
        float N_damage=Normalize(attack.Attack,Min, Max);
        Color damageColor = _gradient.Evaluate(N_damage);
            

        
       text.text = attack.Attack.ToString();
       text.color = damageColor;
    }
    private float Normalize(float damage,float min,float max)
    {
        return Mathf.Clamp01((damage-min)/max-min);
    }
}
