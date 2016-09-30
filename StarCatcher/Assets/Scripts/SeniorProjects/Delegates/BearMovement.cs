using UnityEngine;
using System.Collections;

public class BearMovement : MonoBehaviour
{
    NavMeshAgent navAgent;
    Transform girl;

    void AddGirlHandler (Transform _t)
    {
        girl = _t;
    }

    void OnTriggerStay ()
    {
        navAgent.destination = girl.position;
    }

    void OnTriggerExit()
    {
        navAgent.destination = transform.position;
    }

    void Start ()
    {
        navAgent = GetComponent<NavMeshAgent>();
        GirlRange.AddGirl += AddGirlHandler;
    }
}