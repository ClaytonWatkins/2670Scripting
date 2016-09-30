using UnityEngine;
using System.Collections;
using System;

public class SwitchStatement : MonoBehaviour {

    public enum gameStates {Starting, Playing, Ending}
    public gameStates currentState = gameStates.Starting;

	// Use this for initialization
	void Start () {
      switch (currentState)
        {
            case gameStates.Starting:
                DoSomething("starting", gameStates.Playing);
                break;

            case gameStates.Playing:
                DoSomething("Playing", gameStates.Ending);
                break;

            case gameStates.Ending:
                DoSomething("Ending", gameStates.Ending);
                break;
        }
	}

    private void DoSomething(string v, gameStates gs)
    {
        print ("The game is " + v);
        if(gs != gameStates.Ending)
            Start();
        currentState = gs;
    }
}
