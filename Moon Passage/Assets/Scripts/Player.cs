using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    public float distanceTraveled;

    public bool playerIsAlive = true;

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
        if(playerIsAlive == true)
        {
            distanceTraveled += Time.deltaTime * 10;
            movement = Input.GetAxis("Horizontal") * movementSpeed;
        }         
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }


}
