using UnityEngine;
using System.Collections;

public class DialogDisplay : MonoBehaviour {
	public XMLDialogParser dialogParser;
	public UILabel sentence;
	public DialogEvent eventToTrigger;
	public PointAndClickRaycast raycaster;

	private int currentDialog;
	private int currentBranch;
	public GameObject guiRoot;
	public DynamicButton answerOne;
	public DynamicButton answerTwo;
	public MouseLook mouseX;
	public MouseLook mouseY;
	// Use this for initialization
	void Start () {
		Active();
	}

	// Update is called once per frame

//	void GenerateResponses(string dial, int currentBranch, int indexInScreen) 
//	{
//		DynamicButton b = Instantiate(answerPrefab, Vector3.zero, Quaternion.identity) as DynamicButton;
//		b.transform.parent = guiRoot.transform;
//		b.transform.localScale = Vector3.one;
//		b.receiver = this.gameObject;
//		b.label = dial;
//		b.transform.localPosition = new Vector3(0, indexInScreen * 35, 0);
//	}

	bool waitAnswer = false;

	void Update () {
		if (waitAnswer) return;
		ArrayList branch =  (ArrayList)dialogParser.branchs[currentBranch];
		Dialog dialog;
		if(Input.GetMouseButtonDown(0)){
			if (currentDialog == branch.Count-1){
				dialog = (Dialog) branch[currentDialog];
				if(dialog.responses.Count <= 0){
					EndDialog();
					return;
				}
			}
			currentDialog += 1;	
		}

		if (currentDialog >= branch.Count)
			return;// fin du dialogue

		dialog = (Dialog) branch[currentDialog];
		sentence.text = dialog.name + " : " + dialog.sentence;


		if(dialog.responses.Count > 0)
		{
			waitAnswer = true;

			answerOne.gameObject.SetActive(true);
			answerOne.label = (string)dialog.responses[0];
			answerOne.receiver = this.gameObject;
			answerOne.message = "UpOneBranch";
			answerOne.Active();

			answerTwo.gameObject.SetActive(true);
			answerTwo.label = (string)dialog.responses[1];
			answerTwo.receiver = this.gameObject;
			answerTwo.message = "UpTwoBranch";
			answerTwo.Active();
		}
		else if(currentDialog >= branch.Count){
			EndDialog();
		}
	}

	public void UpOneBranch(){
		currentBranch += 1;
		currentDialog = 0;
		waitAnswer = false;
		answerOne.label = "";
		answerTwo.label = "";
		answerOne.gameObject.SetActive(false);
		answerTwo.gameObject.SetActive(false);
	}

	public void UpTwoBranch(){
		currentBranch += 2;
		currentDialog = 0;
		waitAnswer = false;
		answerOne.label = "";
		answerTwo.label = "";
		answerTwo.gameObject.SetActive(false);
		answerOne.gameObject.SetActive(false);
	}

	public void EndDialog(){
		sentence.gameObject.SetActive(false);
		mouseX.enabled = true;
		mouseY.enabled = true;
		currentBranch = 0;
		currentDialog = 0;
		this.gameObject.SetActive(false);
		eventToTrigger.End();
		raycaster.talking = false;
	}

	public void Active(){
		currentBranch = 0;
		currentDialog = 0;
		sentence.gameObject.SetActive(true);
		mouseX.enabled = false;
		mouseY.enabled = false;
		eventToTrigger.Action();
		raycaster.talking = true;
	}


}
