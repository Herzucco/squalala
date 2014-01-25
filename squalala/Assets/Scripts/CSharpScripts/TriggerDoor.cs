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
		if (other.GetComponent<Inventory>().objectEquiped == neededObject)
		{
			Destroy(Parent);
		}
	}
}
