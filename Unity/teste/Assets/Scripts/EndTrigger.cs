using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;

	 void  OnTriggerEnter(Collider collider) {
		 if (collider.name=="player"){
			gameManager.CompleteLevel();		
		 }
	}


}
