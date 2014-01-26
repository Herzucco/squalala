using UnityEngine;
using System.Collections;

public class MonoWatcher : DialogWatcher {
	public GameObject rain;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update(){
		CheckSentence(dialoger.sentence.text);
	}

	public override void Action(){
		rain.SetActive(true);
	}
}
