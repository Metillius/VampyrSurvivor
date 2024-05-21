using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour, IDamagable
{
    public Transform player; 
    public float moveSpeed = 5f; 
    public float stopDistance = 2f;
    public float health;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > stopDistance)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        
    }


    public void takeDamage(float damage)
    {
        health = health- damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    
}