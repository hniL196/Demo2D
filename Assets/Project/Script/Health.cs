using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;

    private int healthPoint;

    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }
    public void TakeDamage(int damage)
    {
        if (healthPoint < 0)
            return;

        healthPoint -= damage;
        if (healthPoint <= 0)
            Die();
    }
    private void OnTriggerEnter2D(Collider2D collision) => Die();

    protected virtual void Die()
    {
        //var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        //Destroy(explosion, 1f);
        //Destroy(gameObject);
        Debug.Log("Cham");
    }
    
}
