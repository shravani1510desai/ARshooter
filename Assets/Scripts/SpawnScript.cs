using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour

{
    public Transform[] spawnPoints;
    public GameObject[] balloons;

    void Start()
    {
       StartCoroutine(StartSpawning());
    }
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(6);
        for (int i = 0; i < 8; i++ )
        {
            Instantiate(balloons[i], spawnPoints[i].position, Quaternion.identity);
           
        }

        StartCoroutine(StartSpawning());
        
       

    }


}
