using UnityEngine;
using System.Collections;

public class MonsterMove3 : MonoBehaviour {
	private Rigidbody2D body;
	public float jumpHeight;

	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		if(PlayerHealth.playing)
			Move();
	}

	void OnCollisionEnter2D(Collision2D co)
	{
		if(co.gameObject.tag == "Ground")
		{
			body.AddForce(Vector2.up * jumpHeight);
		}
	}

	void Move()
	{
		transform.Translate (-Vector2.right * Time.deltaTime);
	}
}
