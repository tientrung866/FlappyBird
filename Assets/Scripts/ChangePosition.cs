using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    private float np = 6.7f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -np)
        {
            Vector2 newpos = new Vector2(np,transform.position.y);
            transform.position = newpos;
        }
    }
}
