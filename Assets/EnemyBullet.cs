using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	float timer;
	
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 3);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, -10 * Time.deltaTime, 0);
	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.collider.name == "Player")
		{
			Destroy(col.collider.gameObject);
			Destroy(gameObject);
		}
	}
}
