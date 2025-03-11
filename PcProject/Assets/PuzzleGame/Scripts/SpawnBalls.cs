using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject[] spawns;

    void Start()
    {
        StartCoroutine(SpawnBall());
    }

    IEnumerator SpawnBall()
    {
        while (true) 
        {
            for (int i = 0; i < spawns.Length; i++)
            {

                GameObject spawnedBall = Instantiate(ballPrefab, spawns[i].transform.position, Quaternion.identity);
                yield return new WaitForSeconds(1.5f); 
                Destroy(spawnedBall);
                
            }
            yield return new WaitForSeconds(1);

        }
    }
}
