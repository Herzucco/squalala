using UnityEngine;
using System.Collections;

public class SplitScreenManager : MonoBehaviour {
	public Camera leftCamera;
	public Camera rightCamera;
	
	private bool moving;
	private float screenPosition;
	private float speed;
	// Use this for initialization
	void Start () {
		//this.MoveToIn(1f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		if(this.moving){
			this.Move();
		}
	}

	public void MoveToIn(float screenPosition, float speed){
		this.speed = speed;
		this.moving = true;
		this.screenPosition = screenPosition;
	}

	public float screenX{
		get{
			return this.camera.rect.x;
		}
	}

	void Move(){
		Rect leftRect = this.leftCamera.rect;
		Rect rightRect = this.rightCamera.rect;
		Rect splitter = this.camera.rect;
		float lastXSplitter = splitter.x;

		leftRect.width += this.speed * Time.deltaTime;
		rightRect.x += this.speed * Time.deltaTime;
		rightRect.width -= this.speed * Time.deltaTime;
		splitter.x += this.speed * Time.deltaTime;

		this.leftCamera.rect = leftRect;
		this.rightCamera.rect = rightRect;
		this.camera.rect = splitter;

		if(this.camera.rect.x <= lastXSplitter){
			if(this.camera.rect.x <= this.screenPosition){
				this.moving = false;
				return;
			}
		}
		else{
			if(this.camera.rect.x >= this.screenPosition){
				this.moving = false;
				return;
			}
		}
	}
}
