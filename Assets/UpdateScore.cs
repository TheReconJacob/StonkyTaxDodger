using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public static int score;
    public Text scoreText;
    
    void Awake()
    {
        scoreText = GetComponent<Text>();
    }
    
    void Start()
    {
        ResetScore();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
    }
}
