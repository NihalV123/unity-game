using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour {

	bool gamehasended = false;
	public GameObject completelevelUI;
	public float restartdelay =8f;
	public void CompleteLevel()
	{
		completelevelUI.SetActive(true);
		//Debug.Log("Congradulations You won!!");
	}
	public void EndGame()
	{
		if(gamehasended == false)
		{
			gamehasended = true;
			Invoke("Restart",restartdelay);
		}
		//Debug.Log("Game over");
	}

	void Restart()
	{
		// SceneManager.LoadScene("Level1");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
