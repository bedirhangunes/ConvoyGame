using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            SceneManager.LoadScene("finish");
        }
    }
}
