using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth enemyHealth;
    public int Damage;
    public GameObject enemyAtack;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHealth>();
        if (playerHealth != null)
            playerHealth.TakeDamage(Damage);
            enemyHealth.TakeDamage(1000);
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPrefab", Random.Range(0f,5f), Random.Range(1f,10f));
    }
    
    void SpawnPrefab()
    {
        Instantiate(enemyAtack, transform.position, transform.rotation);
    }

}
