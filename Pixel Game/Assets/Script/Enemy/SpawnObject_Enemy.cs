using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject_Enemy : MonoBehaviour
{
    [SerializeField] List<GameObject>spawnobject;
    [SerializeField] PolygonCollider2D Area;
    [SerializeField] int SpawnNumber;
    
    // Update is called once per frame
    private void Awake()
    {
        Spawn();
    }
    void Spawn()
    {
        for (int i = 0; i < SpawnNumber; i++)
        {
            int random=Random.Range(0,spawnobject.Count);
            GameObject selectObject = spawnobject[random];
            Vector2 spawnPos = RandomSpawn(Area);
            Instantiate(selectObject, spawnPos, Quaternion.identity);
           
        }
        
    }
    Vector2 RandomSpawn(PolygonCollider2D box)
    {
        Vector2[] Points = box.points;
        int randomRange = Random.Range(0, Points.Length);

        Vector2 A_Point = Points[randomRange];
        Vector2 B_Point = Points[(randomRange + 1) % Points.Length];

        double t = Random.Range(0f, 1f);
        Vector2 RandomPos = Vector2.Lerp(A_Point, B_Point,(float) t);
        Debug.Log(Points[randomRange]);
        return RandomPos;
    }
}
