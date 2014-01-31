using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	float time = 0.5f;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, Time.deltaTime * 50, 0);
		
		time -= Time.deltaTime;
		
		if (time <= 0)
		{
			Destroy(gameObject);
		}
	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.collider.name == "Enemy(Clone)" || col.collider.name == "EnemyBullet(Clone)")
		{
			if (col.collider.name == "EnemyBullet(Clone)")
			{
				Instantiate(Resources.Load("ExplosionBullet"), col.collider.transform.position, Quaternion.identity);
			}
			if (col.collider.name == "Enemy(Clone)")
			{
				Instantiate(Resources.Load("Explosion"), col.collider.transform.position, Quaternion.identity);
			}
			Destroy(col.collider.gameObject);
			Destroy(gameObject);
		}
	}
}
