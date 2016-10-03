using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour {

    bool canRecycle;

    public static Action<SendToRecycler> SendThis;


	void Start () {
        if(canRecycle && SendThis != null)
         SendThis(this);
	}	
}
