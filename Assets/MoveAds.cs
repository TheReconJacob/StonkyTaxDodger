using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAds : MonoBehaviour
{

    public float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeInHierarchy)
        {
            transform.position += Vector3.left * speed * Time.fixedDeltaTime;
            if(Time.timeScale == 0)
            {
                gameObject.SetActive(false);
            }
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
