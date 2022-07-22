using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingStonk : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    public AudioClip[] bingBongSounds;
    private Rigidbody2D rb;
    private AudioSource audioSource;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(bingBongSounds[Random.Range(0, bingBongSounds.Length)], 10f);
            rb.velocity = Vector2.up * velocity;
        }
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        UpdateScoreAndTax.isDead = true;
        gameManager.ShowMenuScreen(true);
    }
}
