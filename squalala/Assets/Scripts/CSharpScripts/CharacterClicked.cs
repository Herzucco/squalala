using UnityEngine;
using System.Collections;

public class CharacterClicked : MonoBehaviour {
	
	public GUIText dialogueSys;
	
	public DialogEvent jeanEvent;
	public CharacterLink link;
	public DialogDisplay dialScript;
	public GameObject face1;

	public int dialPosition;
	public bool dialLoaded;
	public bool displayTheDial;

	public ArrayList dialogueOfTheCharacter;
	public ArrayList answerToTheCharacter;
}
