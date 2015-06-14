using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetSceneData : MonoBehaviour {

	public Text highScore; 

	// Use this for initialization
	void Start () {
	
		//PlayerPrefs.GetInt ("HighScore");
		Debug.Log ("Restart HighScore" + PlayerPrefs.GetInt ("HighScore"));
		highScore.text = PlayerPrefs.GetInt ("HighScore").ToString ();
	}

}
