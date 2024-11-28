using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
   
    [SerializeField]EnemyParameter enemyParameter;
    [SerializeField]GameObject target;
    [SerializeField] string t_name;

    private void Start()
    {
        target=GameObject.Find(t_name);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, enemyParameter.Speed * Time.deltaTime);
    }
}
