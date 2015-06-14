using UnityEngine;
using System.Collections;

public class EnemyBulletCreator : MonoBehaviour {

	public GameObject bullet;
	//
	public float waitingTime = 1.2f;
	//
	public float angle = 0;
	//
	private float timer;
	
	// Update is called once per frame
	void Update () {

		if (!gameController.pause) {
			//
			timer += Time.deltaTime;
			if(timer > waitingTime){
				//Action
				Vector3 bul_pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
				GameObject bul = (GameObject)Instantiate (bullet, bul_pos, Quaternion.Euler(0, 180, angle));
				//
				timer = 0;
			}
		}

	}
}
