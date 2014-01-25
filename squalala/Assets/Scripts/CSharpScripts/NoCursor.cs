using UnityEngine;
using System.Collections;

public class NoCursor : MonoBehaviour {

	void Start(){
		Screen.showCursor = false;
	}
	void Awake(){
		Screen.showCursor = false;
	}
}
