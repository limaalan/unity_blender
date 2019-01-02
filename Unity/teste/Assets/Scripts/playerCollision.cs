
using UnityEngine;

public class playerCollision : MonoBehaviour {
	public player_movement movement;
	
	void OnCollisionEnter(UnityEngine.Collision collisionInfo){
		if (collisionInfo.gameObject.tag=="Obstaculo"){
			//Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
			
		}
		
	}

	
}
