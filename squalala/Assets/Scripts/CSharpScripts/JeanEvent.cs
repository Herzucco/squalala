using UnityEngine;
using System.Collections;

public class JeanEvent : DialogEvent {
	public ObjectMover objectMover;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void Action(){
		objectMover.moveObject();
	}
	public override void End(){

	}
}
