using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// 弾の速度
	public float speed = 10.0f;
	
	void Start () {
		// 移動させる
		GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
		// 一定時間後に削除
		Destroy (this.gameObject, 5f);
	}
	
	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{
		// 敵とぶつかったら消える
		if(c.tag == "Enemy"){
			Destroy(this.gameObject);
		}	
	}
}
