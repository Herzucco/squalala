using UnityEngine;
using System.Collections;

public class PointAndClickRaycast : MonoBehaviour {
	public RaycastHit hit;
	public Ray ray;
	public float rayDistance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CheckRaycast();
	}

	void CheckRaycast(){
		Ray ray = new Ray(this.transform.position, this.transform.forward);
		Debug.DrawRay(this.transform.position, this.transform.forward*rayDistance);
		if (Physics.Raycast(ray, out hit, rayDistance))
		{
			if (hit.transform.gameObject.tag == "Character")
			{
				if(Input.GetMouseButtonDown(0)){
					CharacterClicked character = hit.transform.gameObject.GetComponent<CharacterClicked>();
					character.displayTheDial = true;
					character.jeanEvent.Action();
					character.dialScript.talkTo();
				}
				if(Input.GetMouseButtonDown(1)){
					CharacterClicked character = hit.transform.gameObject.GetComponent<CharacterClicked>();
					character.displayTheDial = false;
					character.link.SendToOtherWorld();
				}
			}
			//Debug.Log("There is something in front of the object!");
		}
	}
}
