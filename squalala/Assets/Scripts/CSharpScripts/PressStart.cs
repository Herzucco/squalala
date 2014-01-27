using UnityEngine;
using System.Collections;

public class PressStart : MonoBehaviour {

	public string levelName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Jump") || Input.GetButton("Grab") || Input.GetButton("Throw") || Input.GetButton("Kill"))
		{
			Application.LoadLevel(levelName);
		}
	}
}
