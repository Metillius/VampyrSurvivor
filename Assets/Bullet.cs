using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;


    private void Start()
    {
        Invoke("destroyBullet",10);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Debug.Log("Çarptım");
            EnemyFollowPlayer enemy = other.gameObject.GetComponent<EnemyFollowPlayer>();
            if (enemy != null)
            {
                enemy.takeDamage(damage);
            }
            Destroy(gameObject);
        }
    }

    void destroyBullet()
    {
        Destroy(gameObject);
    }
}