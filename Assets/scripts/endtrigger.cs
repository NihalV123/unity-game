using UnityEngine;

public class endtrigger : MonoBehaviour {

	public gamemanager gamemanager;
	public void OnTriggerEnter(Collider other) {
		gamemanager.CompleteLevel();
	}

}
