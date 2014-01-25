using UnityEngine;
using System.Collections;

public class CharacterClicked : MonoBehaviour {

	public GUIText DialogueSys;


	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0)){
			string line = "";
			System.IO.StreamReader file = new System.IO.StreamReader("Assets/Dialogues/" + this.name +".txt");
			while ((line = file.ReadLine()) != null)
			{
				DialogueSys.text = line;
			}
			
			file.Close();
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
