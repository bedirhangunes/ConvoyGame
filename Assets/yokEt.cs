using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokEt : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
        if (other.tag=="sinirr")
        {
            Destroy(gameObject);
        }
    }
}
