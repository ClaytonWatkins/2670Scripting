using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {

    public Transform characterArt;
    public bool forward = true;

    void FlipCharacter (KeyCode _keyCode)
    {
        switch (_keyCode)
        {
            case KeyCode.UpArrow:
                if (forward) {
                    characterArt.Rotate(0, 180, 0);
                    forward = false;
                }
                break;

            case KeyCode.DownArrow:
                if (!forward)
                {
                    characterArt.Rotate(0, 180, 0);
                    forward = true;
                }
                break;
        }
    }

    void StopScript ()
    {
        UserInputs.UserInput -= FlipCharacter;
    }

    void Start ()
    {
        EndGame.GameOver += StopScript;
        UserInputs.UserInput += FlipCharacter;
    }
}
