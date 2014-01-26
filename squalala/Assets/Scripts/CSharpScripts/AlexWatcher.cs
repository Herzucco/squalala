using UnityEngine;
using System.Collections;

public class AlexWatcher : DialogWatcher {
	public SplitScreenManager splitter;
	public string levelToLoad;
	public GameObject FPSCamera;
	public GameObject PointAndClickCamera;
	public GameObject GameOverCamera;
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
	
	IEnumerator RealAction(){
		yield return new WaitForSeconds(2);
		FPSCamera.active = false;
		PointAndClickCamera.active = false;
		GameOverCamera.active = true;
		StartCoroutine(TimerSpawn1());
	}

	IEnumerator TimerSpawn1()
	{
		yield return new WaitForSeconds(5);
		Application.LoadLevel(levelToLoad);
	}
}
