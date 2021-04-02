using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class contPly : MonoBehaviour
{
    float horizontal, vertical, kafaaroot = 0;
    Vector3 vec;
    public Text life;
    int lifeie = 2;
    void Start()
    {
        life.text = "LIFE: " + lifeie;
    }

   
    void Update()
    {
        hareket();   
    }
    void hareket()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec.Set(horizontal, 0, vertical);
        transform.Translate(vec * Time.deltaTime * 100);

        //transform.Translate(0, Input.GetAxis("Mouse X") * 10, 0);
        //kafaaroot += Input.GetAxis("Mouse Y") * Time.deltaTime * 150 * -1;
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "dusman")
        {
            lifeie--;
            life.text = "LIFE: " + lifeie;
            if (lifeie <= 0)
            {
                SceneManager.LoadScene("level");
            }
        }
    }
}
