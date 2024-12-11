using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EXPDisplay : MonoBehaviour
{

    [SerializeField] Slider Exp;
    [SerializeField] PlayerParameter Player;
    // Start is called before the first frame update
    void Start()
    {
        Exp.maxValue = Player.N_Lv;
        Exp.value = Player.Exp;
    }

    // Update is called once per frame
    void Update()
    {
        Exp.maxValue = Player.N_Lv;
        Exp.value = (Player.Exp/Player.N_Lv)*Exp.maxValue;
    }
}
