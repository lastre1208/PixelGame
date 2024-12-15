using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPDisplay : MonoBehaviour
{
    [SerializeField] Slider Hp;
    [SerializeField] PlayerParameter Player;

    // Start is called before the first frame update

    private void Start()
    {
        Hp.maxValue = Player.Common_P.maxHp;
        Hp.value = Player.Common_P.maxHp;
    }
    // Update is called once per frame
    void Update()
    {
        Hp.maxValue = Player.Common_P.maxHp;
        Hp.value = (Player.Common_P.Hp / Player.Common_P.maxHp) *Hp.maxValue;
    }
}
