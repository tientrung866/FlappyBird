using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]private Transform[] spawnPoints;
    
    [SerializeField]private GameObject pipePrefab;

    [SerializeField]private float timeToSpawn = 3f;
    
    private float timeToFirstSpawn = 1f;

    private float timer = 0;

    //Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToFirstSpawn)
        {
            if (timer > timeToSpawn)
            {
                SpawnPipes();
                timer = 0;
            }
            //timeToFirstSpawn = Time.time + timeToSpawn;
        }
        timer += Time.deltaTime;
    }
    
    void SpawnPipes()
    {
        Random rd = new Random();
        int randomIndex = rd.Next(0, spawnPoints.Length);
        SimplePool.Spawn(pipePrefab, spawnPoints[randomIndex].position, Quaternion.identity);

        /*for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                //Instantiate(blockPrefab ,spawnPoints[i].transform.position, Quaternion.identity);
                SimplePool.Spawn(pipePrefab, spawnPoints[i].position, Quaternion.identity);
                //ObjectPooler.Instance.SpawnFromPool("Obstacle", transform.position, Quaternion.identity);
            }
        }*/

    }
}
