using UnityEngine;
using System.Collections;

public class TriggerMove : MonoBehaviour {

	public ObjectMover ObjectMover;

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
			ObjectMover.moveObject();
		}
	}
}
