using UnityEngine;
using System.Collections;
using System.Xml;
using System;

public class XMLDialogParser : MonoBehaviour {
	public string filePath;
	
	public ArrayList branchs;
	private int currentDialog;
	private int currentBranch;
	private XmlDocument xmlDoc;
	// Use this for initialization
	void Start () {
		xmlDoc = new XmlDocument();
		System.IO.StreamReader file = new System.IO.StreamReader("Assets/Dialogues/" + filePath +".xml");
		xmlDoc.LoadXml(file.ReadToEnd());
		branchs = new ArrayList();
		branchs.Add(new ArrayList());
		currentBranch = 0;
		ReadXML();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void ReadXML() {
		DialogNodeParser(xmlDoc.SelectSingleNode("dialog"), currentBranch);
	}

	void DialogNodeParser(XmlNode node, int branch){
		Dialog dialog;
		dialog = new Dialog();

		XmlNodeList childs = node.ChildNodes;

		dialog.sentence = node.SelectSingleNode("sentence/@text").Value;
		dialog.name = node.SelectSingleNode("name/@text").Value;
		int addedBranchs = 0;
		foreach (XmlNode levelsItens in childs)
		{	
			if(levelsItens.Name == "dialog")
			{
				if(levelsItens.Attributes["text"]  != null){
					dialog.responses.Add(levelsItens.Attributes["text"].Value);
				}
			}
		}
		((ArrayList)branchs[branch]).Add(dialog);
		foreach (XmlNode levelsItens in childs)
		{	
			if(levelsItens.Name == "dialog")
			{
				if(levelsItens.Attributes["text"]  != null){
					branchs.Add(new ArrayList());
					addedBranchs++;
					dialog.responses.Add(levelsItens.Attributes["text"].Value);
					DialogNodeParser(levelsItens,  branch+addedBranchs);
				}
				else{
					DialogNodeParser(levelsItens,  branch);
				}
			}
		}
	}
}
