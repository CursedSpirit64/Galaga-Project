using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBad", 0, 0);
        //1.5 distance between each enemy, if not functional use 1.75
    }


    void SpawnBad()
    {
        Debug.Log("Invoked");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
