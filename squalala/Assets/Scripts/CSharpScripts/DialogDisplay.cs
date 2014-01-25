using UnityEngine;
using System.Collections;

public class DialogDisplay : MonoBehaviour {
	public XMLDialogParser dialogParser;
	public GUIText sentence;

	private int currentDialog;
	private int currentBranch;
	public bool isTalking;
	public GameObject guiRoot;
	public DynamicButton answerPrefab;

	// Use this for initialization
	void Start () {
		currentBranch = 0;
		currentDialog = 0;
	}
	
	public void talkTo() {
		isTalking = true;
 	}
	// Update is called once per frame

	void MethodeDePaul(string dial, int currentBranch, int indexInScreen) 
	{
		DynamicButton b = Instantiate(answerPrefab, Vector3.zero, Quaternion.identity) as DynamicButton;
		b.transform.parent = guiRoot.transform;
		b.transform.localScale = Vector3.one;
		b.receiver = this.gameObject;
		b.label = dial;
		b.transform.localPosition = new Vector3(0, indexInScreen * 35, 0);
	}

	bool waitAnswer = false;

	void Update () {
		//if(isTalking == true)
		{
			if (waitAnswer) return;
			if(Input.GetKeyDown("space"))
			{
				currentDialog += 1;
			}

			ArrayList branch = (ArrayList)dialogParser.branchs[currentBranch];
			if (currentDialog >= branch.Count)
				return;// fin du dialogue

			Dialog dialog = (Dialog) branch[currentDialog];

			sentence.text = dialog.name + " : " + dialog.sentence;


			if(dialog.responses.Count > 0)
			{
				waitAnswer = true;
				for (int i = 2; i < dialog.responses.Count; i++)
				{
					MethodeDePaul(((string)dialog.responses[i]), currentBranch+i+1, i);
				}
			}
		}
	}




}
