using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -5)
        {
            SimplePool.Despawn(gameObject);
            //Destroy(gameObject);
        }
    }
}
