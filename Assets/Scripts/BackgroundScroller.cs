using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroller : MonoBehaviour
{
    private RawImage background;
    [SerializeField]
    private float scrollSpeed = 3;
    private float actualScrollSpeed = 0;
    
    void Awake()
    {
        background = GetComponent<RawImage>();
    }

    public void isGamePlaying(bool gamePlaying)
    {
        if (gamePlaying)
        {
            actualScrollSpeed = scrollSpeed / 10;
        }
        else
        {
            actualScrollSpeed = 0;
        }
    }

    void FixedUpdate()
    {
        background.uvRect = new Rect(background.uvRect.position + new Vector2(actualScrollSpeed, 0) * Time.fixedDeltaTime, background.uvRect.size);
    }
}
