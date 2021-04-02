using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rastgeleAraclar : MonoBehaviour
{
    public GameObject araclar;
    public Vector3 randm;

    void Start()
    {
        StartCoroutine(normalArac());
    }
    IEnumerator normalArac()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            for(int g = 0; g < 2; g++)
            {
                Vector3 ve = new Vector3(-randm.x, randm.y, randm.z);
                Instantiate(araclar, ve, Quaternion.identity);
                yield return new WaitForSeconds(8);
            }
            yield return new WaitForSeconds(10);
        }
    }

}
