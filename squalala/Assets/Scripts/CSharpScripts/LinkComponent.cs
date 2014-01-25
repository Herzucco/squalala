using UnityEngine;
using System.Collections;

public class LinkComponent : MonoBehaviour {
	public GameObject target;

	private LinkComponent targetLink;
	private Transform basePosition;
	public Transform hand;

	// Use this for initialization
	void Start () {
		this.basePosition = target.transform;
		this.targetLink = target.gameObject.GetComponent<LinkComponent>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SendToOtherWorld(){
		this.DeleteAction();
		this.target.SetActive(true);
		if (this.target != null){
			this.target.transform.position = hand.position;
		}
		//this.target.transform.position = this.basePosition.position;
		//this.targetLink.AppearAction();
		this.gameObject.SetActive(false);
	}
	public void DeleteAction(){

	}
	public void AppearAction(){

	}
}
