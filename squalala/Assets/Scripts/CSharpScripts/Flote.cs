using UnityEngine;
using System.Collections;
 
public class Flote : MonoBehaviour {
	
	public float delai = 1;
	public float time = 3;
 
void Start(){
		iTween.MoveBy(gameObject, iTween.Hash("z", 2, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", delai, "time", time));
	}
	
	
}