using UnityEngine;
using System.Collections;

public class GrabObject : MonoBehaviour {

	public string objectName;
	public Inventory Inventory;

	public void pickupObject()
	{
			Inventory.NewObject();
			AddObject();
	}

	public string AddObject()
	{
		return objectName;
	}
}
