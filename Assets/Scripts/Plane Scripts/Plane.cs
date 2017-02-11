using UnityEngine;
using System.Collections;

public class Plane : MonoBehaviour {

	public float planeSpeed;

	private Rigidbody2D myBody;

	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
	}

	void Start () {
	
	}

	void Update () {
	
	}

	void FixedUpdate() {
		PlaneMovement ();
	}

	void PlaneMovement() {
		float xAxis = Input.GetAxisRaw ("Horizontal") * planeSpeed;
		float yAixs = Input.GetAxisRaw ("Vertical") * planeSpeed;
		myBody.velocity = new Vector2 (xAxis, yAixs);
	}

}
