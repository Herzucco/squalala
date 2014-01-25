using UnityEngine;
using System.Collections;

public class TriggerDoor : MonoBehaviour {
	
	public GameObject Parent;
	public string neededObject;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		Inventory inventory = other.GetComponent<Inventory>();
		if (inventory != null && inventory.objectEquiped == neededObject)
		{
			Destroy(Parent);
		}
	}
}
