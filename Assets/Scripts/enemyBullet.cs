using UnityEngine;
using System.Collections;

public class enemyBullet : MonoBehaviour {
	
	// 弾の速度
	public float speed;
	// 自動消滅する時間
	public float disappearTime;
	// ターゲット
	public string targetTag; 
	// 弾の方向
	public int direction; 

	void Start () {
		// 移動
		GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed * direction;
		// 一定時間後に削除される
		Destroy (this.gameObject, disappearTime);
	}

}
