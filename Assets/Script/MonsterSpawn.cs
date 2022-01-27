using UnityEngine;
using System.Collections;

public class MonsterSpawn : MonoBehaviour {
	public GameObject mon;
	private bool working = false;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("StartSpawn", 0, 1);
	}

	void StartSpawn()
	{
		if(!PlayerHealth.playing || working){return;}

		working = true;
		int x = Random.Range ((int)(PlayerHealth.gameSpeed/2), PlayerHealth.gameSpeed);
		Invoke ("MakeMonster", x);
	}

	void MakeMonster()
	{
		Instantiate (mon, transform.position, transform.rotation);
		working = false;
	}
}
