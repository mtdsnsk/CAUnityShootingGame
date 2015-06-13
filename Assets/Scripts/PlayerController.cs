using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	// 移動速度
	public float speed = 15f;
	// クリックした位置座標
	private Vector2 target;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1"))
		{
			// 移動
			Vector3 clickPosition = Input.mousePosition;
			target = Camera.main.ScreenToWorldPoint(clickPosition);
		}
		transform.position = Vector3.MoveTowards(transform.position, 
		                                         new Vector2(target.x, transform.position.y),
		                                         speed * Time.deltaTime);
	}

	// Destroyされたら呼ばれる
	void OnDestroy(){
		// 削除されたら呼ばれる
		Debug.Log ("Game Over");
		Application.LoadLevel("GameOver");
	}
}
