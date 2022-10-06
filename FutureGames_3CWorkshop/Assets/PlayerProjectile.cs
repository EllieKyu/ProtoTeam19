using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public int damage;
    public Enemy enemy;
    public MinionAI minionAI;

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.TryGetComponent<BossHealth>(out BossHealth playerHealth))
    //     {
    //         Debug.Log("collision with bosshealth");
    //         bossHealth.TakeDamage(damage);
    //         Destroy(gameObject);
    //
    //     }
    //     Destroy(gameObject);
    // }
    private void Start()
    {
        enemy = GameObject.FindWithTag("Boss").GetComponent<Enemy>();
        minionAI = GameObject.FindWithTag("Minion").GetComponent<MinionAI>();
    }

    

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
    //     {
    //         Debug.Log("collision");
    //         enemyComponent.TakeDamage(1);
    //         
    //     }
    //     
    //     else if (collision.gameObject.TryGetComponent<MinionAI>(out MinionAI minionComponent))
    //     {
    //         Debug.Log("collision");
    //         minionComponent.MinionTakeDamage(1);
    //         
    //     }
    //
    //    
    //
    //     Destroy(this.gameObject);
    // }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Boss"))
        {
            enemy.TakeDamage(1);
            Destroy(this.gameObject);
        }
        else if (other.gameObject.CompareTag("Minion"))
        {
            minionAI.MinionTakeDamage(1);
            Destroy(gameObject);
        }
        
        Destroy(gameObject, 2f);
    }
    
    
}
