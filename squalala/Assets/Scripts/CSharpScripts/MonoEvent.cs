using UnityEngine;
using System.Collections;

public class MonoEvent : DialogEvent {
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void Action(){
		player.BroadcastMessage("boostSpeed");
	}
	public override void End(){
		player.BroadcastMessage("resetSpeed");
	}
}
