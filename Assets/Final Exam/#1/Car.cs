using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    private float verticalInput;
    private float horizontalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
     verticalInput = Input.GetAxis("Vertical");
     horizontalInput = Input.GetAxis("Horizontal");
     rb.velocity = transform.up * verticalInput * moveSpeed;
     rb.angularVelocity = -horizontalInput * turnSpeed;
    }
}
