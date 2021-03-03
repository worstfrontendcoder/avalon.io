using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodEat : MonoBehaviour
{
	public string Tag;
	public float SizeIncrease;
	public Text Letters;

	int Score = 0;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == Tag)
		{
			transform.localScale += new Vector3(SizeIncrease, SizeIncrease, SizeIncrease);
			Score += 10;
			Letters.text = "Score: " + Score;
			Destroy(other.gameObject);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
