using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    bool isSpawning = false;
    public float MinSpawnTime = 5f;
    public float MaxSpawnTime = 5f;
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator SpawnObject(int index, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Instantiate(enemies [index], transform.position, transform.rotation);
        isSpawning = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!isSpawning)
        {
            isSpawning = true;
            int enemyIndex = Random.Range(0, enemies.Length);
            StartCoroutine(SpawnObject(enemyIndex, Random.Range(MinSpawnTime, MaxSpawnTime)));
        }
    }
    
    
}
