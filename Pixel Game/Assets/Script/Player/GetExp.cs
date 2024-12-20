using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GetExp : MonoBehaviour
{
    private Exp _Exp;
    private void Start()
    {
        _Exp = GetComponent<Exp>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
         PlayerParameter player= GameObject.FindWithTag("P_Status").GetComponent<PlayerParameter>();
            player.Exp+=_Exp._exp*player.Exp_Rate;
            Destroy(gameObject);
        }
    }
}
