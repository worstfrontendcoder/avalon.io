using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour
{
    public float Increase;
    public float Decrease;
    
    // this script doesnt work

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "food")
        {
            transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            transform.localScale += new Vector3(Decrease, Decrease, Decrease);
        }

    }

}
