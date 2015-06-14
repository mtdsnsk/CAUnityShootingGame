using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// 弾の速度
	public float speed;
	// 自動消滅する時間
	public float disappearTime;
	// ターゲット
	public string targetTag; 
	// 弾の方向
	public int direction; 
	
	void Start () {
		// 移動させる
		GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed * direction;
		// 一定時間後に削除
		Destroy (this.gameObject, disappearTime);
	}
	
	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{
		// ターゲットとぶつかったら消える
		if(c.tag == targetTag){
			// 自分自身を削除
			Destroy(this.gameObject);
		}	
	}
}
