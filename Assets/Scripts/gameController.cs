using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameController : MonoBehaviour {
	
	// タイマー
	public float gameTimer;
	public Text gameTimerText;
	// スコア
	public int gameScore;
	public Text gameScoreText;

	// Update is called once per frame
	void Update () {
		gameTimer += Time.deltaTime;
		gameTimerText.text = gameTimer.ToString();

		gameScoreText.text = gameScore.ToString();
	}

	//
	public void scoreCount (int n) {
		gameScore += n;
	}
}
