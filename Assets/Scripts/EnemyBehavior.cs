using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float velocityEnemy;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = - *transform.up * velocityEnemy; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "PlayerBullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
