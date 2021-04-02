using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlatma : MonoBehaviour
{
    public GameObject expl;
    void Start()
    {
        
    }

     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "dusman")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            Instantiate(expl, transform.position, transform.rotation);
        }
    }
}
