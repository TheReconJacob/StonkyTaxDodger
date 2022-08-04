using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreAndTax : MonoBehaviour
{
    public static int score;
    public static float tax;
    public static bool isDead = false;
    public Text taxText;
    private float startingTax = 5000;
    private Text scoreText;
    
    void Awake()
    {
        scoreText = GetComponent<Text>();
        gameObject.SetActive(false);
    }
    
    void Start()
    {
        tax = startingTax;
        ResetScore();
    }

    void FixedUpdate()
    {
        scoreText.text = score.ToString();
    }

    void Update()
    {
        if(isDead)
        {
            taxText.gameObject.SetActive(true);
            if(score > 100)
            {
                tax -= ((float) score) / 2;
            }
            else if(score > 50)
            {
                tax -= ((float) score) / 3;
            }
            else if(score > 10)
            {
                tax -= ((float) score) / 4;
            }
            else
            {
                tax -= ((float) score) / 5;
            }

            taxText.text = "Tax left to pay: £" + tax.ToString("F2");
            isDead = false;
        }
    }

    public void EnableScore()
    {
        gameObject.SetActive(true);
    }

    public void ResetScore()
    {
        score = 0;
        taxText.gameObject.SetActive(false);
    }
}
