
using UnityEngine;

public class camfollow : MonoBehaviour {


	public Vector3 offset;
	public Transform player;

	// Update is called once per frame
	void Update () {
		//Debug.Log(player.position);
		transform.position =player.position + offset;
	}
}