using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SPDisplay : MonoBehaviour
{
    [SerializeField] PlayerParameter player;
    [SerializeField] TMP_Text sp;
    void Update()
    {
        sp.text = player.SkillPoint.ToString() + "SP";
    }
}
