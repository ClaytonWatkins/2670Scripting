using UnityEngine;
using System.Collections;

public class MoveRigidBody : MonoBehaviour {

	// Use this for initialization
	private Rigidbody rb;
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce(Vector3.right*300);
	}
	
}
