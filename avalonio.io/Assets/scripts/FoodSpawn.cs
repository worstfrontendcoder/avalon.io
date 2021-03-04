using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{

    public GameObject food;
    public float speed;

 

    private void Start()
    {
        InvokeRepeating("Generate", 0, speed);
    }



    void Generate()
    {

        int x = Random.Range(0, Camera.main.pixelWidth);
        int y = Random.Range(0, Camera.main.pixelHeight);


        Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));
        Target.z = 0;

        Instantiate(food, Target, Quaternion.identity); 


    }


}