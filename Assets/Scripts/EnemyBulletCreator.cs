using UnityEngine;
using System.Collections;

public class EnemyBulletCreator : MonoBehaviour {

	public GameObject bullet;
	//
	private float timer;
	//
	public float waitingTime = 1.2f;
	//
	public float angle = 0;
	
	// Update is called once per frame
	void Update () {
		
		timer += Time.deltaTime;
		if(timer > waitingTime){
			//Action
			Vector3 bul_pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			GameObject bul = (GameObject)Instantiate (bullet, bul_pos, Quaternion.Euler(0, 180, angle));
			
			Destroy (bul.gameObject,  5f);
			timer = 0;
		}
	}
}
