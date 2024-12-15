using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGrid : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] GameObject gridPrefab;
    [SerializeField]int div_X;
    [SerializeField]int div_Y;
    // Start is called before the first frame update
    void Start()
    {
        Set_Grid();
    }

    // Update is called once per frame
   public void Set_Grid()
    {
        Renderer renderer=target.GetComponent<Renderer>();
        Vector3 Size = renderer.bounds.size;
        float width_X=Size.x/div_X;
        float width_Y=Size.y/div_Y;

        for (int y = 0; y < div_Y; y++)
        {

            float position_Y = (target.transform.position.y - Size.y/2  + width_Y * (y ));


            GameObject gridObject = Instantiate(gridPrefab, new(0, position_Y, 0.05f), Quaternion.Euler(0, 0, 90), target.transform);

        }
        for (int x = 0; x < div_X; x++)
        {

            float position_X = (target.transform.position.x - Size.x/2 + width_X * (x ));


            GameObject gridObject = Instantiate(gridPrefab, new(position_X, 0f, 0.05f), Quaternion.Euler(0, 0, 0), target.transform);
        }
    } 
}
