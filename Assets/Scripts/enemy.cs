using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	public gameController _gameController;
	[SerializeField] AnimationCurve curve;
	[SerializeField] float transTime = 1f;
	
	float passedTime = 0f; // 経過時間
	RectTransform rectTrans; // 

	public int life = 0; // 体力
	public int moveSpeed  = 5; // 移動速度

	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{
		//
		if(c.tag == "Player"){
			Application.LoadLevel("GameOver");
		}

		// プレーヤーの弾と衝突
		if (c.tag == "UserBullet") {

			life -= 1; // 体力を減らす
			if(life < 0){ 
				Debug.Log ("敵機を破壊:" + this.name);
				Destroy(this.gameObject);
				//gameController.
			}
		}
	}

//	void Update () {
//		//
//		//this.gameObject.transform.x += Time.deltaTime * moveSpeed;
//	}

	void Start () {
		_gameController = new gameController ();
		this.rectTrans = this.GetComponent<RectTransform> ();
		//GameObject go = GameObject.Find("StageController");
		//print( go.transform.position.x);
		_gameController.scoreCount (1000);
		//Debug.Log ("Name" + go.name);
	}

//	void Update () {
//
//		this.passedTime += Time.deltaTime;
//
//		Debug.Log ("passedTime:" + this.passedTime);
//
//		float per = this.passedTime / this.transTime;
//
//		float val = this.curve.Evaluate (per);
//
//		//rectTrans.localScale = val;
//
//		if (per >= 1)
//			Destroy (this);
//	}
}

