﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;

    Vector2 move = new Vector2();

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        move = new Vector2(x, y);

        if (move.sqrMagnitude > 1)
            move = move.normalized;
    }

    void FixedUpdate()
    {
        rb2d.velocity = move * speed;
    }
}
