﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {

	public void comecarJogo(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}

}
