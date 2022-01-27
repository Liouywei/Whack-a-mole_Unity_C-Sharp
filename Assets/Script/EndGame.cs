using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D co)
	{
		if(co.gameObject.tag == "Monster")
		{
			PlayerHealth.playing = false;
			Application.LoadLevel (0);
		}
	}
}
