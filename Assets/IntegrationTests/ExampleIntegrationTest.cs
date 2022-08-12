using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class ExampleIntegrationTest
{
    [UnityTest]
    public IEnumerator TestThatScoreUpdatesToOne()
    {
        SceneManager.LoadScene("GameScene");
        yield return new WaitForSeconds(0);
        UpdateScoreAndTax.score++;
        var scoreText = GameObject.Find("Score").GetComponentInChildren<Text>();
        scoreText.text = UpdateScoreAndTax.score.ToString();

        Assert.AreEqual("1",scoreText.text);
    }
}
