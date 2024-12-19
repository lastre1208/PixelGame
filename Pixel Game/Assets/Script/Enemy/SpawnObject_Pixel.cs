using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject_Pixel : MonoBehaviour
{
    [SerializeField] List<GameObject> spawnobject;
    [SerializeField] SpriteRenderer Area;
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
            int random = Random.Range(0, spawnobject.Count);
            GameObject selectObject = spawnobject[random];
            Vector2 spawnPos = RandomSpawn(Area);
            Instantiate(selectObject, spawnPos, Quaternion.identity);

        }

    }
    Vector2 RandomSpawn(SpriteRenderer box)
    {
        Vector2 Center = box.bounds.center;
        Vector2 Size = box.bounds.size;
        float spawn_X = Random.Range(Center.x - Size.x / 2, Center.x + Size.x / 2);
        float spawn_Y = Random.Range(Center.y - Size.y / 2, Center.y + Size.y / 2);
        return new Vector2(spawn_X, spawn_Y);
    }
}