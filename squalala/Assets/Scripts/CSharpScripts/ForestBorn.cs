using UnityEngine;
using System.Collections;

public class ForestBorn : MonoBehaviour {

	public GameObject bridge;
	public GameObject forestToMove;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.name == "Seed")
		{
			iTween.MoveBy(forestToMove, iTween.Hash("y", 5, "easeType", "easeInOutExpo", "delay", 0, "time", 3));
			iTween.MoveBy(bridge, iTween.Hash("z", -18, "easeType", "easeInOutExpo", "delay", 0, "time", 3));

		}
	}
}
