using UnityEngine;
using System.Collections;

public class PlayerRaycast : MonoBehaviour {

	public RaycastHit hit;
	public Ray ray;
	public float rayDistance;
	private string hitObject;
	private GameObject hitGameObject;
	public Component[] allMesh;
	public GameObject allLevel;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {

		ray = new Ray(this.transform.position, this.transform.forward);
		Debug.DrawRay(this.transform.position, this.transform.forward*rayDistance);
		if (Physics.Raycast(ray, out hit, rayDistance))
		{
			if (hit.transform.gameObject.tag == "Object")
			{
				if(Input.GetButton("Grab"))
				{
					hit.transform.gameObject.GetComponent<GrabObject>().pickupObject();
					hitObject = hit.transform.gameObject.GetComponent<GrabObject>().objectName;
					hitGameObject = hit.transform.gameObject;
					HitedObject();
					HitedGameObject();
				}
				if(Input.GetButton("Kill")){
					hit.transform.gameObject.GetComponent<ObjectLink>().SendToOtherWorld();
				}
			}
			//Debug.Log("There is something in front of the object!");
		}

	}

	public string HitedObject()
	{
		return hitObject;
	}

	public GameObject HitedGameObject()
	{
		return hitGameObject;
	}
}
