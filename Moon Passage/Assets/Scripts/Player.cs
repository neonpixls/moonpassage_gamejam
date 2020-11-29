using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    public float distanceTraveled;

    [SerializeField] UIController uiController;

    Rigidbody2D rb;
    
    [SerializeField] float movementSpeed = 10f;

    float movement = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        distanceTraveled += Time.deltaTime;
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
