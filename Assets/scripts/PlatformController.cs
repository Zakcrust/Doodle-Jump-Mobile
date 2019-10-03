using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

	public float jumpForce = 15f;

	void OnCollisionEnter2D(Collision2D collision)
	{
		Vector2 colliderPos = collision.collider.transform.position;
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				if(colliderPos.y > transform.position.y)
				{
					Vector2 velocity = rb.velocity;
					velocity.y = jumpForce;
					rb.velocity = velocity;
					this.gameObject.SetActive(false);
				}
				
			}
	}
}
