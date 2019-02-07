using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gira : MonoBehaviour {

	// Use this for initialization
	public int speed=10;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward*Time.deltaTime*speed);
		
	}
}
