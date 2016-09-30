using UnityEngine;
using System.Collections;

public class DestroyClone : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter () {
		Destroy(gameObject);
	}

}
