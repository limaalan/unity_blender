using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useSelectedMaterial : MonoBehaviour {

	public Material[] materials ;
	public GameObject player;

	// Use this for initialization
	void Start () {
		player.GetComponent<Renderer>().material = materials[PlayerPrefs.GetInt("cor")];
		
	}

}
