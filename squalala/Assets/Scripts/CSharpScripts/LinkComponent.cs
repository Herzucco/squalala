using UnityEngine;
using System.Collections;

public class LinkComponent : MonoBehaviour {
	public GameObject target;

	private LinkComponent targetLink;
	// Use this for initialization
	void Start () {
		this.targetLink = target.gameObject.GetComponent<LinkComponent>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SendToOtherWorld(){
		this.DeleteAction();
		this.target.SetActive(true);
		this.targetLink.AppearAction();
		this.gameObject.SetActive(false);
	}
	public void DeleteAction(){

	}
	public void AppearAction(){

	}
}
