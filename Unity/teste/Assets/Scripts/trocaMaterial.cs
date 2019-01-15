using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trocaMaterial : MonoBehaviour {
public Material[] materials ;
public GameObject player;

public bool aumentando;

private int materialAtual;

	// Use this for initialization
	
	void Start () {
	materialAtual=0;
	mudaMaterial(materialAtual);	
	}
	
	
	public void mudaMaterial(int indice){
		player.GetComponent<Renderer>().material = materials[indice];
	 }
	
	public void troca(bool aumentando){
		if (aumentando){ materialAtual++;}
		else{ materialAtual--;}
		
		if(materialAtual>2){
			materialAtual=0;
		}
		if( materialAtual <0){
			materialAtual=2;
		}

		mudaMaterial(materialAtual);
		
	}
	// Update is called once per frame
	
	public void comeca(){
		PlayerPrefs.SetInt("cor",materialAtual);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
}


