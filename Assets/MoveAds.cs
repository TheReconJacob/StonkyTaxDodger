using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAds : MonoBehaviour
{

    public float speed = 2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gameObject.activeInHierarchy)
        {
            transform.position += Vector3.left * speed * Time.fixedDeltaTime;
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
            gameObject.SetActive(false);
        }
    }
}
