
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

	public Text scoreText;
	public Transform player;
	public float offset=47.497f;
	// Update is called once per frame
	void Update () {
		//Debug.Log(player.position.z + offset);
		scoreText.text = ((player.position.z)-offset).ToString("0");
	}
}
