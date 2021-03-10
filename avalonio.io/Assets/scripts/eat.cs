using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour
{
    public float Increase;
    public float Decrease;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale += new Vector3(Decrease, Decrease, Decrease);
        }



    }


}
