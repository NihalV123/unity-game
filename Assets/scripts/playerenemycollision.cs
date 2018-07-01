
using UnityEngine;

public class playerenemycollision : MonoBehaviour {

public playermove movement;
public gamemanager gamemanager;
	void OnCollisionEnter(Collision collisioninfo)
	{
		//name of enemy
		//Debug.Log(collisioninfo.collider.tag);
	if(collisioninfo.collider.tag == "Finish")
	{
		movement.enabled = false;
		//Debug.Log("Level cleared");
		FindObjectOfType<gamemanager>().EndGame();
	}
	if(collisioninfo.collider.tag == "wall")
	{
		movement.enabled = false;
		FindObjectOfType<gamemanager>().EndGame();
		//Debug.Log("bounce player");
	}
	if(collisioninfo.collider.tag == "enemy")
	{
		movement.enabled = false;
		FindObjectOfType<gamemanager>().EndGame();
		//Debug.Log("Reset");
	}
	}
}
