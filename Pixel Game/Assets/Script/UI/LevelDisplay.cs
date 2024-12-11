using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]PlayerParameter player;
    [SerializeField] TMP_Text text;
    void Start()
    {
        text.text = ""+player.Lv;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + player.Lv;
    }
}
