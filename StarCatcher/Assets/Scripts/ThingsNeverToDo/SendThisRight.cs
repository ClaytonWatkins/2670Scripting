using UnityEngine;
using System.Collections;
using System;

public class SendThisRight : MonoBehaviour {

    public static Action<GameObject> SendThis;

    void Start () {
        if(SendThis != null)
             SendThis(gameObject);
	}
}
