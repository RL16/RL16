using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float Walk;
	private CharacterController charactercontroller;
	private Vector3 velocity;
	public GameObject Clear1;//追記部分、右のカメラのClearの文字を指定
	public GameObject Clear2;//追記部分、左のカメラのClearの文字を指定

	// Use this for initialization
	void Start () {
		charactercontroller = GetComponent<CharacterController> ();
		Clear1.SetActive(false);//追記部分、右のカメラのClearの文字を非表示にする
		Clear2.SetActive(false);//追記部分、左のカメラのClearの文字を非表示にする
	}

	// Update is called once per frame
	void Update () {
		transform.position += transform.TransformDirection(Vector3.forward * Walk * Time.deltaTime);
		charactercontroller.Move (velocity);
		velocity.y += Physics.gravity.y;
	}

	void OnCollisionEnter(Collision col)//追記部分ここから、衝突判定の処理
	{
		if (col.gameObject.tag == "Chest") {//衝突したオブジェクトのタグが"Chest"なら
			Clear1.SetActive(true);//右のカメラのClearの文字を表示する
			Clear2.SetActive(true);//左のカメラのClearの文字を表示する
		}
	}
}