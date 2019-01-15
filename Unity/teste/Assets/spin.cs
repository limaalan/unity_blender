using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {

	public Transform player;
	public int speed=5;

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		player.Rotate(Vector3.one*Time.deltaTime*speed);
		
		
	}
}
