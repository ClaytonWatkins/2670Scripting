using UnityEngine;
using System.Collections;
using System;

public class PlayerControllers : MonoBehaviour {

    public static Action PlayDeath;

	// Use this for initialization
	void OnMouseDown () {
        PlayDeath();
	}
}
