using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 bulletOffset;
    public float shootingInterval;

    private float lastBulletTime;

    // Start is called before the first frame update
    void Start()
    {
        lastBulletTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        Shooting();
    }

      void Moving()
    {
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;
    }

    void Shooting()
    {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
                lastBulletTime = Time.time;
            }      
    }
}
