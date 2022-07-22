using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public static int score;
    public static Text scoreText;
    
    void Awake()
    {
        scoreText = GetComponent<Text>();
        gameObject.SetActive(false);
    }
    
    void Start()
    {
        ResetScore();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = score.ToString();
    }

    public void EnableScore()
    {
        gameObject.SetActive(true);
    }

    public void ResetScore()
    {
        score = 0;
    }
}
