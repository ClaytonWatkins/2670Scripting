using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

    public NavMeshAgent myAgent;
    public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        myAgent.destination = player.position;
	}
}
