using UnityEngine;
using System.Collections;

public class PlayVideo : MonoBehaviour {

	public MovieTexture movTexture;
	public AudioSource movSound;
	public string levelName;

	void Start() {
		renderer.material.mainTexture = movTexture;
		movTexture.Play();
		movSound.Play();
	}

	void Update() {
		if (movTexture.isPlaying == false)
		{
			Application.LoadLevel(levelName);
		}
	}

}
