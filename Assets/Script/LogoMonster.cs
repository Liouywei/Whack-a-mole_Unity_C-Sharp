using UnityEngine;
using System.Collections;

public class LogoMonster : MonoBehaviour {
	private Animator anim;
	private Transform mt;
	private bool move = false;
	public int movespeed;

	void Start()
	{
		anim = GetComponent<Animator> ();
		mt = gameObject.transform;
	}

	void FixedUpdate()
	{
		if(move)
			transform.Translate (-Vector2.right * Time.deltaTime * movespeed);
	}

	void OnMouseEnter()
	{
		anim.SetBool("Click", true);
		mt.localScale = new Vector2 (1.5f, 1.5f);
	}

	void OnMouseExit()
	{
		anim.SetBool("Click", false);
		mt.localScale = new Vector2 (1, 1);
	}

	void OnMouseDown()
	{
		if(move){return;}

		move = true;
		Invoke ("GameStart", 3);
	}

	void GameStart()
	{
		Application.LoadLevel (1);
	}
}
