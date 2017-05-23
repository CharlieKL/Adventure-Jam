using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTextAtLine : MonoBehaviour {

	public TextAsset theText;
	public int startLine;
	public int endLine;

	[Header("Display Settings")]
	[Tooltip("This is the entities name")]

	public string myDisplayName;

	public TextBoxManager theTextBox;

	public bool requiredButtonPress;
	private bool waitForPress;

	public bool destroyWhenActivated;

	// Use this for initialization
	void Start () {

		theTextBox = FindObjectOfType<TextBoxManager>();

		myDisplayName = this.gameObject.name;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (waitForPress && Input.GetKeyDown(KeyCode.Space)){

			theTextBox.ReloadScript(theText);
			theTextBox.currentLine = startLine;
			theTextBox.endAtLine = endLine;
			theTextBox.displayNameString = myDisplayName;
			theTextBox.EnableTextBox();

			if (destroyWhenActivated) {
				Destroy(gameObject);
			}
		}
		}

	void OnTriggerEnter (Collider other) {

		if (other.name == "Player") {

			if(requiredButtonPress){
				waitForPress = true;
				return;
			}

			theTextBox.ReloadScript(theText);
			theTextBox.currentLine = startLine;
			theTextBox.endAtLine = endLine;
			theTextBox.EnableTextBox();

			if (destroyWhenActivated) {
				Destroy(gameObject);
			}
		}
	}

	void OnTriggerExit (Collider other){

		if (other.name == "Player"){
			waitForPress = false;
		}

	}

}
