using UnityEngine;
using System.Collections;

public class CharacterClicked : MonoBehaviour {
	
	public GUIText dialogueSys;
	
	public DialogEvent jeanEvent;
	public CharacterLink link;
	public DialogDisplay dialScript;
	private int dialPosition;
	bool displayTheDial;
	
	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0) && displayTheDial == false){
			displayTheDial = true;
			jeanEvent.Action();
			dialScript.talkTo();
		}
		if(Input.GetMouseButtonDown(1)){
			displayTheDial = false;
			link.SendToOtherWorld();
		}
	}
	
	void OnMouseEnter(){
		//save the original material color
		this.transform.renderer.material.color = Color.cyan;
	}
	
	void OnMouseExit(){
		this.transform.renderer.material.color = Color.white;
	}
}