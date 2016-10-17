using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindThingsRight : MonoBehaviour {

    public List<GameObject> level;

    void AddToList (GameObject _go)
    {
        level.Add(_go);
    }

    void Start()
    {
        SendThisRight.SendThis += AddToList;
    }
}
