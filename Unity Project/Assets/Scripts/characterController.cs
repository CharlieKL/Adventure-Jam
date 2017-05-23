using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {


	public bool canMove;
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!canMove) {
			return;
		}

		float translation = Input.GetAxis("Vertical") * speed;
		//float straffe = Input.GetAxis("Horizontal") * speed;
		translation *= Time.deltaTime;
		//straffe *= Time.deltaTime;

		transform.Translate(/*straffe,*/0, 0, translation);
		
	}
}
