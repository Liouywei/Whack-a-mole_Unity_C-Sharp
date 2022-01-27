using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FinalGrade : MonoBehaviour {
	public GameObject nextObj;

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "Time : " + PlayerHealth.timmer.ToString()  + " sec";
	}

	void MonsterOpen()
	{
		nextObj.SetActive (true);
	}

}
