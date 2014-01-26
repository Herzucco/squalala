using UnityEngine;
using System.Collections;

public class MonoWatcherSnow : DialogWatcher {
	public GameObject snow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public override void Action(){
		snow.SetActive(true);
	}
}
