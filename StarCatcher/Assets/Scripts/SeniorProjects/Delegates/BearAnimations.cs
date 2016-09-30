using UnityEngine;
using System.Collections;

public class BearAnimations : MonoBehaviour {

    static Animator anim;
    public BearMovement BM;


	void Start ()
    {
        anim = GetComponent<Animator>();

        GameObject bearAI = GameObject.Find("BearController");
        //BM = GetComponent<BearMovement>();
    }
	
	void Update ()
    {
        //GameObject bearAI = GameObject.Find("BearController");
        BM = GetComponent<BearMovement>();

        //if (BM.bearWalking == true)
       //     anim.SetBool("IsWalking", true);
       // else
       //     anim.SetBool("IsWalking", false);

       // if (BM.bearTalking == true)
      //      anim.SetBool("IsTalking", true);
      //  else
       //     anim.SetBool("IsTalking", false);
    }
}
