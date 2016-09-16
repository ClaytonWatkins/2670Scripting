using UnityEngine;
using System.Collections;
using System;

public class PlayerAnims : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerControllers.PlayDeath = PlayDeathHandler;
	}

    private void PlayDeathHandler()
    {
        print("Running Death animation");
    }
}
