using UnityEngine;

public class playermove : MonoBehaviour {

	public Rigidbody rb;

	public float forwardforce =300f;
	public float buttonforce =500f;

	//fixedupdate used for physx
	void FixedUpdate () 
	{
		rb.AddForce(0,0,forwardforce * Time.deltaTime);
		//delta time to avoid variable frame rate

		//key bindings
		if(Input.GetKey("d"))
		{
			rb.AddForce(buttonforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("a"))
		{
			rb.AddForce(((buttonforce)*-1) * Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(rb.position.y < -1f)
		{
			FindObjectOfType<gamemanager>().EndGame();
		}
		
	}


}
