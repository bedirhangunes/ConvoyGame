using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirEnemy : MonoBehaviour
{
    public Vector3 randomi;
    public GameObject trucky;
    void Start()
    {
        StartCoroutine(creatTruck());
    }

   
   IEnumerator creatTruck()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            for(int h = 0; h < 1; h++)
            {
                Vector3 vecete = new Vector3(-randomi.x, randomi.y, randomi.z);
                Instantiate(trucky, vecete, Quaternion.identity);
                yield return new WaitForSeconds(50);
            }
            yield return new WaitForSeconds(60);
        }
    }
}
