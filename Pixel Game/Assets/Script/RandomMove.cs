using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Range
{
   public float x;
    public float y;
}
public class RandomMove : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] Range _range;
    private Vector3 randomPosition;
    void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-_range.x, _range.x), Random.Range(_range.y, _range.y));
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position=Vector3.MoveTowards(transform.position,randomPosition,Speed*Time.deltaTime);
    }
}
