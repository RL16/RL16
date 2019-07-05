using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComplete : MonoBehaviour {

	public float Walk;
	private CharacterController charactercontroller;
	private Vector3 velocity;
	public GameObject Clear1;
	public GameObject Clear2;

	// Use this for initialization
	void Start () {
		charactercontroller = GetComponent<CharacterController> ();
		Clear1.SetActive(false);
		Clear2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.TransformDirection(Vector3.forward * Walk * Time.deltaTime);
		charactercontroller.Move (velocity);
		velocity.y += Physics.gravity.y;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Chest") {
			Clear1.SetActive(true);
			Clear2.SetActive(true);
		}
	}
}