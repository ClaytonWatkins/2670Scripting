using UnityEngine;
using System.Collections;
using System;

public class GirlRange : MonoBehaviour {

    public static Action<Transform> AddGirl;

	// Use this for initialization
	void Start () {
        AddGirl(transform);
	}

}
