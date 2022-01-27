using UnityEngine;
using System.Collections;

public class MonsterMove2 : MonoBehaviour {
	private bool doing = false;
	public float bb;
	private Vector2 v2;
	public Transform m_obj;
	private Rigidbody2D body;

	void Start()
	{
		body = GetComponent<Rigidbody2D> ();
		body.gravityScale = 0;
		v2 = -Vector2.right;
	}

	void FixedUpdate () {
		if(PlayerHealth.playing)
			Move ();
	}

	void Move()
	{
		Vector2 temp = m_obj.localScale;
		temp.x = (v2 != -Vector2.right) ? -1 : 1;
		m_obj.localScale = temp;

		Invoke ("MoveTime", Random.Range (1, 4));

		transform.Translate (v2 * Time.deltaTime);
	}

	void MoveTime()
	{
		if (doing) {return;}

		float times;
		doing = true;
		if (Random.value <= bb)
		{
			v2 = -Vector2.right;
			times = 2.5f;
		}
		else
		{
			v2 = Vector2.right;
			times = 1.5f;
		}
		Invoke("DoingWhat", Random.Range(0, times));
	}

	void DoingWhat()
	{
		doing = false;
	}
}
