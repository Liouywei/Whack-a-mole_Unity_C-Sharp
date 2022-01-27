using UnityEngine;
using System.Collections;

public class MonsterMove1 : MonoBehaviour {

	void FixedUpdate () {
		if(PlayerHealth.playing)
			Move ();
	}

	void Move()
	{
		transform.Translate (-Vector2.right * Time.deltaTime);
	}
}
