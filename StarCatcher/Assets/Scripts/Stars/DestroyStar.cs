using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour {

    public float endTime = 3;

	void OnCollisionEnter () {
        Destroy(gameObject, endTime);
    }

    //IEnumerator EndStar()
    //{
    //    yield return new WaitForSeconds(endTime);
    //}
}
