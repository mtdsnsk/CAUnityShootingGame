using UnityEngine;
using System.Collections;

public class enemyBullet : MonoBehaviour {

	// 弾の速度 
	public float speed = -15.0f;

	void Start () {
		// 移動
		GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
		// 一定時間後に削除される
		Destroy (this.gameObject, 5f);
	}
	
	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{
		if(c.tag != "Enemy"){
			//
			Destroy(this.gameObject);
		}

		if(c.tag == "Player"){
			//
			Destroy(c.gameObject);
		}	
	}
}
