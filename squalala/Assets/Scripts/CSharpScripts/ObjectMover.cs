using UnityEngine;
using System.Collections;

public class ObjectMover : MonoBehaviour {
	
	public Vector3 desiredPosition;
	public float floatTime;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	public void moveObject()
	{
		iTween.MoveTo(this.gameObject, desiredPosition, floatTime);
	}
}