using UnityEngine;
using System.Collections;

public class FranDialogWatcher : DialogWatcher {
	public GameObject pont1;
	public GameObject pont2;
	// Use this for initialization
	void Start () {
	
	}
	
	void Update(){
		CheckSentence(dialoger.sentence.text);
	}

	public override void Action(){
		pont1.SetActive(true);
		pont2.SetActive(true);
	}
}
