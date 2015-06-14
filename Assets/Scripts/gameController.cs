using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameController : MonoBehaviour {
	
	// タイマー
	public float gameTimer;
	public Text gameTimerText;
	// スコア
	static public int gameScore;
	public Text gameScoreText;

	static public bool pause;
	//spaceship

	void Start () {
		pause = false;
		gameScore = 0;
	}

	// Update is called once per frame
	void Update () {

		if(!gameController.pause){

			gameTimer += Time.deltaTime;
			gameTimerText.text = gameTimer.ToString();

			gameScoreText.text = gameScore.ToString();

		}

	}

	//
	void OnDestroy() {

		int score = PlayerPrefs.GetInt("HighScore");

		// ハイスコア記録
		if(gameScore > score){
			// スコア更新
			PlayerPrefs.SetInt ("HighScore", gameScore);
			PlayerPrefs.Save ();
		}

	}

}
