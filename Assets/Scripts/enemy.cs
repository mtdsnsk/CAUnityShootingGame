using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{

		if(c.tag == "Player"){
			Application.LoadLevel("GameOver");
		}
		
		if (c.tag == "UserBullet") {
			Destroy (c.gameObject);
		}
	}
}

