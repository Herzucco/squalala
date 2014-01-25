using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	public string objectEquiped;
	public PlayerRaycast TriggerInventory;
	public GameObject Hands;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (TriggerInventory != null && TriggerInventory.HitedGameObject() != null && objectEquiped == TriggerInventory.HitedObject())
		{
			TriggerInventory.HitedGameObject().transform.position = Hands.transform.position;
			//TriggerInventory.HitedGameObject().GetComponent<BoxCollider>().enabled = false;
			if(Input.GetButton("Throw"))
			{
				ThrowObject();
			}
		}
	}

	void ThrowObject()
	{
		//TriggerInventory.HitedGameObject().GetComponent<BoxCollider>().enabled = true;
		TriggerInventory.HitedGameObject().rigidbody.velocity = Hands.transform.forward*10;
		objectEquiped = "";
	}

	public void NewObject () {
		objectEquiped = TriggerInventory.HitedObject();
	}
}
