using UnityEngine;
using System.Collections;

public class loopje : MonoBehaviour {
	
	float moveX;
	float moveY;
	float tijd;
	
	void Start()
	{
		for (int _x = 0; _x < 10; _x++)
		{
			for (int _y = 0; _y < 10; _y++)
			{
				float xSet = -5 + (_x * 1.5f);
				float ySet = 5 + (_y * 1.5f);
				
				Instantiate(Resources.Load("Enemy"), new Vector3(xSet, ySet, 0), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		moveX = Input.GetAxis("Horizontal") * 10 * Time.deltaTime;
		moveY = Input.GetAxis("Vertical") * 10 * Time.deltaTime;
		
		transform.Translate(0, moveY, 0, Space.World);
		transform.Translate(moveX, 0, 0, Space.World);
		
		if (Input.GetAxis("Fire1") > 0 && tijd == 0)
		{
			Instantiate(Resources.Load ("Bullet"), transform.position, Quaternion.identity);
			tijd = 0.3f;
		}
		
		if (tijd > 0)
		{
			tijd -= Time.deltaTime;
			
			if (tijd < 0)
			{
				tijd = 0;
			}
		}
	}
	
}
