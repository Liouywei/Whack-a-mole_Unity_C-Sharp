using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MonsterControl : MonoBehaviour {
	public float maxHp;
	public float hp;
	public Image hpbar;
	private RectTransform rt;

	void Start()
	{
		rt = hpbar.GetComponent<RectTransform> ();
	}

	void FixedUpdate()
	{
		float x = 0f + 0.6f * (hp/maxHp);
		float y = rt.sizeDelta.y;
		rt.sizeDelta = new Vector2(x, y);
	}

	 void OnMouseDown()
	{
		if(!PlayerHealth.playing){return;}

		GetHurt ();
	}

	void OnMouseEnter()
	{
		hpbar.enabled = true;
	}

	void OnMouseExit()
	{
		hpbar.enabled = false;
	}

	void GetHurt()
	{
		hp--;
		
		if (hp <= 0)
		{
			Destroy (gameObject);
		}
	}
}
