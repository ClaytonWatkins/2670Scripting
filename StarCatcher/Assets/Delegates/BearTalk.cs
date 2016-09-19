using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BearTalk : MonoBehaviour {

    public enum BearTalkingStates {One, Two, Three, Done};
    public BearTalkingStates currentTalkingState;

    public List<string> phrases0;
    public List<string> phrases1;
    public List<string> phrases2;

    IEnumerator Talk (List<string> _phrases)
    {
        int i = 0;
        while (i < _phrases.Count)
        {
            print(_phrases[i]);
            yield return new WaitForSeconds(1);
            i++;
        }
    }

	// Use this for initialization
	void OnTriggerEnter ()
    {
        StartTalking();
    }

    private void StartTalking()
    {
        switch (currentTalkingState)
        {
            case BearTalkingStates.One:
                StartCoroutine(Talk(phrases0));
                currentTalkingState = BearTalkingStates.Two;
                break;
            case BearTalkingStates.Two:
                StartCoroutine(Talk(phrases1));
                currentTalkingState = BearTalkingStates.Three;
                break;
            case BearTalkingStates.Three:
                StartCoroutine(Talk(phrases2));
                currentTalkingState = BearTalkingStates.Done;
                break;
        }
    }
}
