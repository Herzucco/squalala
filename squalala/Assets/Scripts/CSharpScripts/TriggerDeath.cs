using UnityEngine;
using System.Collections;

public class TriggerDeath : MonoBehaviour {

	public string levelName;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Application.LoadLevel(levelName);
		}
		if (other.tag == "Object")
		{
			Application.LoadLevel(levelName);
		}
	}
}
