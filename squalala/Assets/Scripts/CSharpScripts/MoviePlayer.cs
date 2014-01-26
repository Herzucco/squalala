using UnityEngine;
using System.Collections;

public class MoviePlayer : MonoBehaviour {

	public MovieTexture endVideo;
	public GameObject movieCamera;
	public GameObject fpsCamera;
	public GameObject pointAndClickCamera;
	public GameObject cible;

	// Use this for initialization
	void Start () {
		LaunchVideo();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void LaunchVideo() {
		movieCamera.active = true;
		fpsCamera.active = false;
		pointAndClickCamera.active = false;
		cible.renderer.material.mainTexture = endVideo;
		endVideo.Play();
	}
}
