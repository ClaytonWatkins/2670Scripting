using UnityEngine;
using System.Collections;

public class RecycleLevelObject : MonoBehaviour {

    private Vector3 newLocation;

	void OnTriggerEnter()
    {
        newLocation.x = StaticVars.nextSectionPosition;
        transform.position = newLocation;
        StaticVars.nextSectionPosition += StaticVars.distance;
    }
}
