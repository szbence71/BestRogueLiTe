using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;

    private Rigidbody2D rb;
    private Animator animator;

    private Vector2 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        animator.SetBool("isMoving", movementDirection.sqrMagnitude >= 0.1f);
        
        if (movementDirection.y > 0)
        {
            animator.SetInteger("Direction", 2); // W
        }
        else if (movementDirection.x > 0)
        {
            animator.SetInteger("Direction", 3); // D
        }

        else if (movementDirection.x < 0)
        {
            animator.SetInteger("Direction", 1); // A
        }
        else if (movementDirection.y < 0)
        {
            animator.SetInteger("Direction", 0); // S
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}