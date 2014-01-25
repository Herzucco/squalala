using UnityEngine;
using System.Collections;

public class BilboardPlane : MonoBehaviour {
	
	public Camera Cam;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 v = Cam.transform.forward;
		v.y += 90;
		transform.rotation = Quaternion.LookRotation(v);
	}
}
