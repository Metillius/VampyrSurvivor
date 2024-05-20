using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 movementVector = Vector2.zero;
    private Rigidbody2D riggid = null;
    public float moveSpeed = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        riggid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime;
        Vector3 mouseScreenPosition = Input.mousePosition;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        
        Vector2 direction = new Vector2(mouseWorldPosition.x - transform.position.x,mouseWorldPosition.y-transform.position.y);
        transform.up = direction;
    }
}
