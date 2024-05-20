using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    public Transform player; 
    public float moveSpeed = 5f; 
    public float stopDistance = 2f; 

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
}