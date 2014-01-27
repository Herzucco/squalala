using UnityEngine;
using System.Collections;

public class TriggerDeath : MonoBehaviour {

	public string levelName;
	public GameObject FPSCamera;
	public GameObject PointAndClickCamera;
	public GameObject GameOverCamera;
	public float duration;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name != "Seed" && (other.tag == "Player" || other.tag == "Object"))
		{
			FPSCamera.active = false;
			PointAndClickCamera.active = false;
			GameOverCamera.active = true;
			StartCoroutine(TimerSpawn1());
		}
	}
	
		IEnumerator TimerSpawn1()
		{
			yield return new WaitForSeconds(duration);
			Application.LoadLevel(levelName);
		}
}
