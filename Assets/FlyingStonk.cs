using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingStonk : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        gameManager.ShowMenuScreen();
    }
}
