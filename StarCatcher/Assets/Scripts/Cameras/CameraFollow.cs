using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public NavMeshAgent navAgent;
    public Transform player;

	void Update () {
        navAgent.destination = player.position;
	}
}
