using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public int = badX;
    public int = badY;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyCounter(20));
        //1.5 distance between each enemy, if not functional use 1.75
    }

    IEnumerator MyCounter(int number)
    {
        int i = 0;
        while (i < number)
        {
            Debug.Log("badX is " + badX.ToString());
            Instantiate(enemy, Vector2(badX, badY), Quaternion.identity);
            badX -= -1.5f;
            yield return 0;

            i++;
        }
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
