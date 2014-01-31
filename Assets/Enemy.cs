using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	float timer;
	float reloadTime;
	
	// Use this for initialization
	void Start () {
		reloadTime = Random.value * 100;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		
		if (timer > reloadTime)
		{
			Instantiate(Resources.Load("EnemyBullet"), transform.position, Quaternion.identity);
			timer = 0;
				
			reloadTime = Random.value * 100 + 20;
		}
	}
}
