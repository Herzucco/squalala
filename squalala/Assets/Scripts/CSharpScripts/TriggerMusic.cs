using UnityEngine;
using System.Collections;

public class TriggerMusic : MonoBehaviour {
	public AudioSource sound;
	public string tagToFilter;

	private bool passed;
	// Use this for initialization
	void Start () {
		passed = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(!passed && other.gameObject.tag == tagToFilter){
			sound.Play();
			passed = true;
		}
	}
}
