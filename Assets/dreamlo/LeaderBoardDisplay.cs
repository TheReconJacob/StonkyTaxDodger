using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class LeaderBoardDisplay : MonoBehaviour {
    public Text[] scoreTexts;
	
	public DreamloLeaderBoard leaderBoard;

	void Start()
	{
		gameObject.SetActive(false);
	}
	void OnEnable() 
	{
		List<DreamloLeaderBoard.Score> scoreList = leaderBoard.ToListHighToLow();
		int count = 0;
		foreach (DreamloLeaderBoard.Score currentScore in scoreList)
		{
			scoreTexts[count].text = $"{count+1}: " + currentScore.playerName + " - " + currentScore.score;
			count++;
		}
        leaderBoard.GetScores();
	}
}
