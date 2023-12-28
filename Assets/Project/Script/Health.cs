using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    public string requiredTag = "Bonus";

    private int healthPoint;

    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }
    public void TakeDamage(int damage)
    {
        if (healthPoint < 0)     
            return;
        
        else        
            healthPoint -= damage;
        
        if (healthPoint <= 0)
            Die();
    }

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1f);
        Destroy(gameObject);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag(requiredTag))
    //        Debug.Log("Bonus");
    //    else
    //        Die();
    //}

}
