using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//
	public GameObject panel;

	// 移動速度
	public float speed = 8f;
	// クリックした位置座標
	private Vector2 target;
	//
	public GameObject explosion;
	//
	public int life;
	//
	private GameObject effect;
	//
	bool isAlive;


	void Start () {
		// 生きてる
		isAlive = true;
	}

	// Update is called once per frame
	void Update () {

		if (isAlive) {

			if (Input.GetButton ("Fire1")) {
				// 移動
				Vector3 clickPosition = Input.mousePosition;
				target = Camera.main.ScreenToWorldPoint (clickPosition);
			}
			transform.position = Vector3.MoveTowards (transform.position, 
			                                          new Vector2 (target.x, target.y),
		                                         speed * Time.deltaTime);

			if (life <= 0) {

				// 死亡
				isAlive = false;

				//
				gameController.pause = true;

				// effect
				GameObject effect = (GameObject)Instantiate (explosion.gameObject, this.gameObject.transform.position, Quaternion.identity);
				Destroy (effect, 3.0f);
			
				//
				StartCoroutine ("GameOver");
			}

		}
	}

//	// Destroyされたら呼ばれる
//	void OnDestroy(){
//
//		PlayerPrefs.SetInt ("HighScore", 1009);
//		PlayerPrefs.Save ();
//
//		Debug.Log ("HighScore:" + PlayerPrefs.GetInt("HighScore"));
//
//		// effect
//		GameObject effect = (GameObject)Instantiate(explosion.gameObject, this.gameObject.transform.position, Quaternion.identity);
//		Destroy (effect, 5.0f);
//
//		 //
//		StartCoroutine ("GameOver");
//
//	}

	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{
		if(c.tag == "Enemy"  || c.tag == "EnemyBullet"){
			//
			life -= 1;
		}
	}

	IEnumerator GameOver(){

		//GameObject panel = GameObject.Find ("GameOverPanel");
		panel.gameObject.SetActive (true);

		yield return new WaitForSeconds(3); // ３秒待つ
		 //実行する内容
		// 削除されたら呼ばれる
		Debug.Log ("Game Over");
		Application.LoadLevel("GameOver");
	}
}
