using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyController : MonoBehaviour {

	public List<GameObject> Enemies;

	public float speed = 5.0f;

	//
	private float timer;
	//
	private float waitingTime = 1.2f;

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer > waitingTime){
			//Action
			Vector3 bul_pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			GameObject enemy = (GameObject)Instantiate (Enemies[0], bul_pos, Quaternion.identity);
			enemy.transform.rotation = Quaternion.Euler(0, 0, 90);
			enemy.GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed * -1;
			Destroy (enemy,  5f);
			timer = 0;
		}
	}

//	// ぶつかった瞬間に呼び出される
//	void OnTriggerEnter2D (Collider2D c)
//	{
//		Debug.Log (" Enter enemy : " + c.name);
//
//		if(c.tag == "Player"){
//			Application.LoadLevel("GameOver");
//		}
//
//		if (c.tag == "UserBullet") {
//			Destroy (c.gameObject);
//		}
//	}

//	// ぶつかった瞬間に呼び出される
//	void OnCollisionEnter2D (Collider2D c)
//	{
//		Debug.Log (" Collision player : " + c.name);
//		Destroy (c);
//	}
}
