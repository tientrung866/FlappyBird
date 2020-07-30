using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using Random = System.Random;

public class PipeSpawnCon : MonoBehaviour
{
    [SerializeField] private float timeToSpawn;
    
    [SerializeField] private GameObject pipePrefab;
    
    [SerializeField] private float height;
    
    private float timer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = SimplePool.Spawn(pipePrefab);
        newpipe.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > timeToSpawn)
        {
            GameObject newpipe = SimplePool.Spawn(pipePrefab);
            newpipe.transform.position = transform.position + new Vector3(0, UnityEngine.Random.Range(-height, height), 0);
            //SimplePool.Despawn(newpipe);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
