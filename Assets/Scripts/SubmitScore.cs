using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitScore : MonoBehaviour
{
    public InputField input;
    public DreamloLeaderBoard leaderBoard;

    public void SubmitUserScore()
    {
        if(input.text != "")
        {
            leaderBoard.AddScore(input.text,UpdateScoreAndTax.score);
        }
    }
}
