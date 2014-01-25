using UnityEngine;
using System.Collections;

public class CharacterClicked : MonoBehaviour {

	public GUIText dialogueSys;
	public GUIText answers1;
	public GUIText answers2;
	public GUIText answers3;
	public DialogEvent jeanEvent;
	public CharacterLink link;

	public int dialPosition;
	public bool dialLoaded;
	public bool displayTheDial;

	public ArrayList dialogueOfTheCharacter;
	public ArrayList answerToTheCharacter;

	void Start(){
		dialogueOfTheCharacter = new ArrayList();
		answerToTheCharacter = new ArrayList();
		dialPosition = 0;
		string line = "";
		string ans = "";
		System.IO.StreamReader file = new System.IO.StreamReader("Assets/Dialogues/" + this.name +"-questions.txt");
		while ((line = file.ReadLine()) != null)
		{
			dialogueOfTheCharacter.Add(line);	
		}
		dialLoaded = true;
		System.IO.StreamReader file2 = new System.IO.StreamReader("Assets/Dialogues/" + this.name +"-reponses.txt");
		while ((ans = file2.ReadLine()) != null)
		{
			answerToTheCharacter.Add(ans);	
		}
		file.Close();
	}

	void Update(){
		if(displayTheDial == true)
		{
			if(dialPosition < dialogueOfTheCharacter.Count)
			{
				if(Input.GetKeyDown("space"))
				{
					dialPosition += 1;
				}
				if(dialLoaded == true)
				{
					if(((string) dialogueOfTheCharacter[dialPosition]).Contains("??"))
					{
						answers1.text = (string) answerToTheCharacter[0];
						answers2.text = (string) answerToTheCharacter[1];
						answers3.text = (string) answerToTheCharacter[2];
					}

					dialogueSys.text = (string) dialogueOfTheCharacter[dialPosition];
				}
			}
			else
			{
				dialogueSys.text ="";
			}
		}
	}

	void FixedUpdate(){
		transform.renderer.material.color = Color.white;
	}
}
