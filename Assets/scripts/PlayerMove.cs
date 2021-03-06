﻿using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public scoretext st;


	// Use this for initialization
	public float speed = 15.0F;
	public float jumpspeed = 8.0F;
	public float gravity = 20.0F;
	public float mouse_sense = 5.0F;
	public Vector3 moveDirection = Vector3.zero;
	private Animator animator;
	public bool finish;
    private GameObject camera_parent;
    public Vector3 old_pos;
    

    void Start () {
		animator = GetComponent<Animator>();
		FadeManager.Instance.DebugMode = false;
        camera_parent = Camera.main.transform.parent.gameObject;
        

    }

    // Update is called once per frame
    void Update () {

		//移動の設定
		CharacterController controller = GetComponent<CharacterController> ();
		if (true) {
			if (finish == false) {
				moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
				if (Input.GetAxis ("Vertical") != 0) {
					animator.SetBool ("Running", true);
				} else {		
					animator.SetBool ("Running", false);
				}
			
			} else {
				moveDirection = Vector3.zero;
				animator.SetBool ("Running", false);
				FadeManager.Instance.LoadLevel ("result", 0.5F);
			}

			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;
			//本来ならジャンプの処理
		
		

		} 
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);

		transform.Rotate (0, Input.GetAxis("Mouse X")*mouse_sense, 0);
		
		camera_parent.transform.Rotate (0, 0, Input.GetAxis ("Mouse Y") * mouse_sense);

        //distanceText.distance += Mathf.Sqrt (Mathf.Pow (moveDirection.x*Time.deltaTime, 2) + Mathf.Pow (moveDirection.z*Time.deltaTime, 2));
        distanceText.distance += Mathf.Sqrt(Mathf.Pow(old_pos.x - GetComponent<Transform>().position.x, 2) + Mathf.Pow(old_pos.z - GetComponent<Transform>().position.z, 2));
        old_pos = GetComponent<Transform>().position;

    }

	void OnTriggerEnter(Collider hit){
		
		if (hit.gameObject.CompareTag ("point")) {
			st.score++;
		}
	
	}
}
