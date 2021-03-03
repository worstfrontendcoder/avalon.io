using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour
{
    public float increase;
    public float decrease;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "food")
        {
            transform.localScale += new Vector3(increase, increase, increase);
            Destroy(other.gameObject);
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            transform.localScale += new Vector3(decrease, decrease, decrease);
        };
    }
}
