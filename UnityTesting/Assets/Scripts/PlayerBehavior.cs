using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{
	public GameObject missile;

	public float turnspeed;
	Vector3 turnRight = new Vector3 (0, 15.0f, 0);
	Vector3 turnLeft = new Vector3 (0, -15.0f, 0);

	public int speedFactor;
	private float speed = 0.0f;
	private float accelerate = 0.1f;
	private float decelerate = 0.01f;

	private Vector3 momentum = new Vector3 ();

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (speed < 0) {
			speed = 0;
		} else if (speed > 50) {
			speed = 50;
		}
		transform.Translate (momentum * speed * speedFactor * Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.Space)) {
			// Fire!
		}
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			momentum = momentum + transform.forward;
			speed = speed + accelerate;
		} else if (speed > 0) {
			speed = speed - decelerate;
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (turnLeft * turnspeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (turnRight * turnspeed * Time.deltaTime);
		}
	}
}
