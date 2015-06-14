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
	public string targetTag;
	public float disappearTime; 
	public GameObject explosion; // 爆発のエフェクト

	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{
		if(!gameController.pause){
			// プレーヤーの弾と衝突
			if (c.tag == targetTag) {
				life -= 1; // 体力を減らす
				if(life < 0){ 
					Debug.Log ("敵機を撃破 :" + this.name);
					Destroy(this.gameObject);
					
					// effect
					GameObject effect = (GameObject)Instantiate(explosion.gameObject, this.gameObject.transform.position, Quaternion.identity);
					Destroy (effect, 1.0f);
					
					gameController.gameScore += 100;
					
					//GameObject spark = GameObject.Find("Score");
					//spark.GetComponent<Text>().text = "test";
				}
			}
		}

	}
	
	void Start () {
		//_gameController = new gameController ();
		//this.rectTrans = this.GetComponent<RectTransform> ();
		//GameObject go = GameObject.Find("StageController");
		//print( go.transform.position.x);
		//_gameController.scoreCount (1000);
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

