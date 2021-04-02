using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contrGame : MonoBehaviour
{
    public GameObject car;
    public Vector3 randomYer;
    void Start()
    {
        StartCoroutine(enemyUreme());   
    }

    IEnumerator enemyUreme()
    {
        yield return new WaitForSeconds(3);
        while (true)
        {
            for(int j = 0; j < 3; j++)
            {
                Vector3 vecc = new Vector3(Random.Range(-randomYer.x, randomYer.x), randomYer.y, randomYer.z);
                Instantiate(car, vecc, Quaternion.identity);
                yield return new WaitForSeconds(15);
            }
            yield return new WaitForSeconds(15);
        }
    }
}
