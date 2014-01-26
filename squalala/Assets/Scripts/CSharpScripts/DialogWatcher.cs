using UnityEngine;
using System.Collections;

public class DialogWatcher : MonoBehaviour {
	public DialogDisplay dialoger;
	public string wantedDialog;

	private bool realized;
	// Use this for initialization
	void Start () {
		realized = false;
	}
	
	// Update is called once per frame
	void Update () {
		CheckSentence(dialoger.sentence.text);
	}

	protected void CheckSentence(string text){
		if(!realized && text == this.wantedDialog){
			realized = true;
			Action();
		}
	}

	public virtual void Action(){

	}
}
