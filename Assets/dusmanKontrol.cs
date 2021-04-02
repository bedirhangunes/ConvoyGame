using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanKontrol : MonoBehaviour
{
    public Vector3 randomg;
    public GameObject arac;
    void Start()
    {
        StartCoroutine(enemyCreat());
    }

   IEnumerator enemyCreat()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for (int a = 0;a < 3; a++)
            {
                Vector3 vectt = new Vector3( randomg.x, randomg.y, randomg.z);
                Instantiate(arac, vectt, Quaternion.identity);
                yield return new WaitForSeconds(10);
            }
            yield return new WaitForSeconds(10);
        }
    }
}
