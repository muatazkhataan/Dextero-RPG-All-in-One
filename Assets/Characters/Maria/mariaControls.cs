using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mariaControls : MonoBehaviour {

	static Animator anim;
	//int isAttacking = Animator.StringToHash("isAttacking");

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Z))
		{
			print("isAttacking");
			anim.SetTrigger("isAttacking");

		}
	}
}
