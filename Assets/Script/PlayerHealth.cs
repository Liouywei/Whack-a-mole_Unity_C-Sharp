using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour {
	public float maxhp;
	public float hp;
	public Image img;
	private RectTransform rt;

	//GameSet
	public static int timmer;
	public static bool playing = true;
	public static int gameSpeed; // 10 to 1  slow to fast

	
	void Start()
	{
		gameSpeed = 10;
		timmer = 0;
		InvokeRepeating ("RunTimmer", 0, 1);
		rt = img.GetComponent<RectTransform> ();
	}

	void FixedUpdate()
	{
		float x = rt.sizeDelta.x;
		float y = 0 + 290 * (hp/maxhp);
		rt.sizeDelta = new Vector2(x, y);
	}

	void OnCollisionEnter2D(Collision2D co)
	{
		if(co.gameObject.tag == "Monster")
		{
			Destroy(co.gameObject);
			GetHurt();
		}
	}

	void OnTriggerEnter2D(Collider2D co)
	{
		if(co.tag == "Monster")
		{
			Destroy(co.gameObject);
			GetHurt();
		}
	}

	void GetHurt()
	{
		hp--;

		if (hp <= 0)
		{
			playing = false;
			CancelInvoke("RunTimmer");
			Invoke ("LoseGame", 1.5f);
		}
	}

	void LoseGame()
	{
		playing = true;
		Application.LoadLevel (2);
	}

	void RunTimmer()
	{
		timmer++;
		if(timmer % 15 == 0)
		{
			if(gameSpeed > 0)
				gameSpeed --;
		}
	}
}
