using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

    public NavMeshAgent myAgent;
    public Transform player;

	// Update is called once per frame
	void Update () {
        myAgent.destination = player.position;
	}
}
