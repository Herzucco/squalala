﻿using UnityEngine;
using System.Collections;

public class DynamicButton : MonoBehaviour 
{

	public string message;
	public GameObject receiver;
	public string label;

	void Start()
	{
		GetComponent<UIButtonMessage>().target = receiver;
		GetComponent<UIButtonMessage>().functionName = message;
		GetComponentInChildren<UILabel>().text = label;
	}

}
