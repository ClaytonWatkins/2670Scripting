using UnityEngine;
using System.Collections;

public class InstancePrefab : MonoBehaviour {

	public bool canFire;
	public GameObject cube;
	IEnumerator Instance () {
		while (canFire) {
			Instantiate(cube, transform.position, Quaternion.identity);
			yield return new WaitForSeconds(1);
		}
	}
	// Use this for initialization
	void Start () {
		StartCoroutine(Instance());
	}
}
