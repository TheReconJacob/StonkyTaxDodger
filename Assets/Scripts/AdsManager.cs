using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsManager : MonoBehaviour
{
    [SerializeField] Sprite[] ads;
    private SpriteRenderer[] spriteRenderers;

    public float speed = 2f;
    
    void Awake()
    {
        spriteRenderers = GetComponentsInChildren<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if(gameObject.activeInHierarchy)
        {
            transform.position += Vector3.left * speed * Time.fixedDeltaTime;
        }
    }

    void Start()
    {
        Sprite ad = ads[Random.Range(0, ads.Length)];
        foreach(SpriteRenderer spriteRenderer in spriteRenderers)
        {
            spriteRenderer.sprite = ad;
            spriteRenderer.size = new Vector2(3.2f,13.8f);
        }
    }

    void Update()
    {
        if(Time.timeScale == 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.tag == "ObstacleKiller")
        {
            Sprite ad = ads[Random.Range(0, ads.Length)];
            foreach(SpriteRenderer spriteRenderer in spriteRenderers)
            {
                spriteRenderer.sprite = ad;
                spriteRenderer.size = new Vector2(3.2f,13.8f);
            }
            gameObject.SetActive(false);
        }
    }
}
