using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour
{
    public float Increase;


    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "food")
        {

            transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);

        }
        


    }


}
