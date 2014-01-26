using UnityEngine;
using System.Collections;

public class AlexWatcher : DialogWatcher {
	public SplitScreenManager splitter;
	public string levelToLoad;
	// Use this for initialization
	void Start () {
	
	}
	
	void Update(){
		CheckSentence(dialoger.sentence.text);
	}

	public override void Action(){
		splitter.MoveToIn(1f, 0.2f);
		StartCoroutine(RealAction());
	}

	IEnumerator RealAction() {
		yield return new WaitForSeconds(5);
		Application.LoadLevel(levelToLoad);
	}
}
