using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//
	public GameObject bullet;
	//
	public float speed = 15f;
	// クリックした位置座標
	private Vector2 target;
	//
	private float timer;
	//
	private float waitingTime = 0.4f;

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1"))
		{
			Vector3 clickPosition = Input.mousePosition;
			target = Camera.main.ScreenToWorldPoint(clickPosition);
		}
		transform.position = Vector3.MoveTowards(transform.position, 
		                                         new Vector2(transform.position.x, target.y), 
		                                         speed * Time.deltaTime);
//
//		timer += Time.deltaTime;
//		if(timer > waitingTime){
//			//Action
//			Vector3 bul_pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
//			GameObject bul = (GameObject)Instantiate (bullet, bul_pos, Quaternion.identity);
//			Destroy (bul,  2f);
//			timer = 0;
//		}

	}
	
	void OnDestroy(){
		Debug.Log ("Game Over");
		Application.LoadLevel("GameOver");
	}
}
