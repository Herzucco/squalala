using UnityEngine;
using System.Collections;

public class ObjectMover : MonoBehaviour {
	
	public Vector3 desiredPosition;
	public float floatTime;

	private Vector3 basePosition;
	// Use this for initialization
	void Start () {
		basePosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	public void moveObject()
	{
		iTween.MoveTo(this.gameObject, desiredPosition, floatTime);
	}

	public void Reset(){
		iTween.MoveTo(this.gameObject, basePosition, floatTime);
	}
}