using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{


    public GameObject originalFood;

    // Start is called before the first frame update
    void Start()
    {
        Genreat(3);
    }

    void Genreat(int foodsNum)
    {
        for (int i = 0; i < foodsNum; i++)
        {
            GameObject foodClone = Instantiate(originalFood, new Vector3(i, originalFood.transform.position.y, i), originalFood.transform.rotation );
        };
    }
}
