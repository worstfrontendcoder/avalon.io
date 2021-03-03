using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
	public GameObject Food;
	public float Speed;

	void FoodGenerate()
	{
		int x = Random.Range(0, Camera.main.pixelWidth);
		int y = Random.Range(0, Camera.main.pixelHeight);

		Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));
		Target.z = 0;

		Instantiate(Food, Target, Quaternion.identity);
	}
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FoodGenerate", 0, Speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
