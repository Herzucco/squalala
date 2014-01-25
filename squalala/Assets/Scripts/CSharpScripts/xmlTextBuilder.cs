using UnityEngine;
using System.Collections;
using System.Xml;
using System;

public class XmlTextBuilder : MonoBehaviour {
	public string filePath;

	private XmlDocument xmlDoc;
	// Use this for initialization
	void Start () {
		xmlDoc = new XmlDocument();
		System.IO.StreamReader file = new System.IO.StreamReader("Assets/Dialogues/" + filePath +".xml");
		xmlDoc.LoadXml(file.ReadToEnd());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ReadXML() {
		Dialog dialog;
		foreach (XmlNode node in xmlDoc.SelectNodes("dialog") )
		{
			dialog = new Dialog();
			dialog.sentence = node.SelectSingleNode("sentence").InnerText;
			
			LoadBook(book);
		}
	}
}
