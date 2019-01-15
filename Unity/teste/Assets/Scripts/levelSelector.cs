using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelector : MonoBehaviour {

	public void select(int levelName){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+levelName);
	}

}
