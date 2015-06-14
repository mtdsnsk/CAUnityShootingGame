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
	//
	private float stageLevel;

	// Update is called once per frame
	void Update () {

		if (!gameController.pause) {
			timer += Time.deltaTime;
			if(timer > waitingTime){
				//Action
				float pos_x = Random.Range(-4, 4);
				float pos_y = Random.Range(-4, 4);
				Vector3 bul_pos = new Vector3(transform.position.x + pos_x, transform.position.y + pos_y, transform.position.z);
				
				int num = Random.Range(0, 5);
				Instantiate (Enemies[num], bul_pos, Quaternion.Euler(0, 0, 180));
				timer = 0;
			}
		}

	}
}
