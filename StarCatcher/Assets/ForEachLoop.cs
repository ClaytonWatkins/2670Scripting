using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {

    public string[] powerUps = { "Health", "Ammo", "Magic", "Shield"};

	// Use this for initialization
	void Start () {
	    foreach (string _powerUp in powerUps)
        {
            print("I found a " + _powerUp + " power-up on the way to grandmas.");
        }


	}
	
}
