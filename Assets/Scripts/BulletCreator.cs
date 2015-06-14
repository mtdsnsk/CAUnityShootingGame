using UnityEngine;
using System.Collections;

public class BulletCreator : MonoBehaviour {

	public Bullet bul;

	public GameObject bullet;
	// 射出する感覚
	public float waitingTime = 0.4f;
	//
	public float angle = 0;

	//
	private float timer;

	// Update is called once per frame
	void Update () {

		if(!gameController.pause){

			timer += Time.deltaTime;
			if(timer > waitingTime){
				// 弾を発射
				Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
				Instantiate (bullet, position, Quaternion.Euler(0, 0, angle));
				// タイマを戻す
				timer = 0;
			}
		}
	}
}
