using UnityEngine;
using System.Collections;

public class BulletCreator : MonoBehaviour {

	public GameObject bullet;
	//
	private float timer;
	//
	private float waitingTime = 0.4f;

	// Update is called once per frame
	void Update () {
		
		timer += Time.deltaTime;
		if(timer > waitingTime){
			//Action
			Vector3 bul_pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			GameObject bul = (GameObject)Instantiate (bullet, bul_pos, Quaternion.identity);
			Destroy (bul,  2f);
			timer = 0;
		}
	}
}
