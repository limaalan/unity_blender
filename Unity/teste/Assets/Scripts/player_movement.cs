using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

	public Rigidbody rb;

	
	public float fowardForce = 2000f;
	public float sidewaysFoce = 500f;

	// Use this for initialization
	void Start () {
		Debug.Log("Hello world!");
		
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0,fowardForce * Time.deltaTime);

		if (Input.GetKey("d")) {
			rb.AddForce(sidewaysFoce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		
		if (Input.GetKey("a")) {
			rb.AddForce(-sidewaysFoce*Time.deltaTime,0,0,ForceMode.VelocityChange);
			
		}
		
		if (rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}
		
	}

}
