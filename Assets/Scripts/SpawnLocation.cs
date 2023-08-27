using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocation : MonoBehaviour
{  
    
    public GameObject stick;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SmallCircleSpawn();
        }
    }
    void SmallCircleSpawn()
    {
        Instantiate(stick,transform.position,transform.rotation);
    }
}
