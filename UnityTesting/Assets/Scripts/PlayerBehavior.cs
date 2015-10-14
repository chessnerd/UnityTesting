using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{
	public Rigidbody player;
	public GameObject missile;

	public float turnspeed;
	Vector3 turnRight = new Vector3 (-15.0f, 0, 0);
	Vector3 turnLeft = new Vector3 (15.0f, 0, 0);

	public int speedFactor;
	private float accelerate = 0.1f;
	private float decelerate = 0.01f;

	private Vector3 velocity = new Vector3 ();

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			// Fire!
		}
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			velocity = velocity + player.gameObject.transform.forward;
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (turnLeft * turnspeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (turnRight * turnspeed * Time.deltaTime);
		}
		player.AddForce (velocity);
		if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.UpArrow)) {
			velocity = Vector3.zero;
		}
	}
}
