using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float movementSpeed = 10.0f;
	public float gravitySpeed = 1.0f;


	private float movement = 0.0f;
	private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb2d.velocity;
		velocity.x = movement;
		//velocity.y -= gravitySpeed;
		rb2d.velocity = velocity;

		cekPlayerPosition();

	}

	void cekPlayerPosition()
	{
		Vector3 playerPos = transform.position;
		if(playerPos.x > 3.0f)
		{
			playerPos.x = -3.0f;
			transform.position = playerPos;	
		}
		else if(playerPos.x < -3.0f)
		{
			playerPos.x = 3.0f;
			transform.position = playerPos;
		}
			
	}
}
