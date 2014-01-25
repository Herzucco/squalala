using UnityEngine;
using System.Collections;

public class Dialog : MonoBehaviour {

	public string sentence;
	public string name;
	public ArrayList responses;


	public Dialog(){
		responses = new ArrayList();
	}
}
