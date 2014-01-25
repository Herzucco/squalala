using UnityEngine;
using System.Collections;

public class DialogDisplay : MonoBehaviour {
	public XMLDialogParser dialogParser;
	public GUIText sentence;

	private int currentDialog;
	private int currentBranch;
	// Use this for initialization
	void Start () {
		currentBranch = 0;
		currentDialog = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
		{
			currentDialog += 1;
		}
		ArrayList branch = (ArrayList)dialogParser.branchs[currentBranch];
		Dialog dialog = (Dialog) branch[currentDialog];
		sentence.text = dialog.name + " : " + dialog.sentence;
	}
	
}
