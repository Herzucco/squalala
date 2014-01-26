using UnityEngine;
using System.Collections;

public class MonoWatcherSoap : DialogWatcher {
	public GameObject soap;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public override void Action(){
		soap.SetActive(true);
	}
}
