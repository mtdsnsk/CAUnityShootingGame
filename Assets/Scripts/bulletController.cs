using UnityEngine;
using System.Collections;

public class bulletController : MonoBehaviour {

	public gameController _gameController;
	public float speed = 10.0f;

	void Start () {
		//
		GetComponent<Rigidbody2D>().velocity = transform.right.normalized * speed;
		//
		Destroy (this, 3f);
	}

	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{
		Debug.Log (" Collision bullet : " + c.name);

		if(c.tag == "Enemy"){
			Debug.Log("削除");
			Destroy(this.gameObject);
			Destroy(c.gameObject);
			//_gameController.scoreCount(100);
		}

	}

}
