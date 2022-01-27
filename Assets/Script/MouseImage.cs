using UnityEngine;
using System.Collections;

public class MouseImage : MonoBehaviour {
	private Animator anim;

	void Awake()
	{
		DontDestroyOnLoad (gameObject);
		anim = GetComponent<Animator>();
	}

	void Update()
	{
		Move ();
		MouseState ();
	}

	void Move()
	{
		Vector2 v = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		transform.position = v;
	}

	void MouseState()
	{
		if (Input.GetMouseButtonDown (0))
			anim.SetBool ("Click", true);
		else
			anim.SetBool("Click", false);
	}
}
