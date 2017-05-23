using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponActivate : MonoBehaviour {

	public GameObject sword;
	public GameObject swordBack;

	public bool showSword;
	public bool swordAway;

	// Use this for initialization
	void Start () {

		showSword = false;
		swordAway = true;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (showSword == false) {
			sword.SetActive(false);
		}

		if (swordAway == false) {
			swordBack.SetActive(false);
		}

		if (showSword == true) {
			sword.SetActive(true);
		}

		if (swordAway == true) {
			swordBack.SetActive(true);
		}

		if (Input.GetKeyDown(KeyCode.Alpha1) && showSword == false) {
			showSword = true;
			swordAway = false;
		}

		if (Input.GetKeyDown(KeyCode.X) && swordAway == false) {
			showSword = false;
			swordAway = true;
		}


		
	}
}
