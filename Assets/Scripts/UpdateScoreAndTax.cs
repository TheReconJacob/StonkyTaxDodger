using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreAndTax : MonoBehaviour
{
    public static float score;
    public static float tax;
    public static bool isDead = false;
    public Text taxText;
    private int startingTax = 5000;
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
                tax -= score / 2;
            }
            else if(score > 50)
            {
                tax -= score / 3;
            }
            else if(score > 10)
            {
                tax -= score / 4;
            }
            else
            {
                tax -= score / 5;
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
