using UnityEngine;
using UnityEngine.SceneManagement;

public class creditos : MonoBehaviour {
	public void quit() {
		Debug.Log("Saindo...");
		Application.Quit();	
	}

	public void menu() {
		SceneManager.LoadScene("Menu");

	}
}
