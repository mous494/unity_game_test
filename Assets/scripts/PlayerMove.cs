using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	public float speed = 15.0F;
	public float jumpspeed = 8.0F;
	public float gravity = 20.0F;
	public float mouse_sense = 5.0F;
	public Vector3 moveDirection = Vector3.zero;
	private Animator animator;
	void Start () {
		animator = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

		//移動の設定
		CharacterController controller = GetComponent<CharacterController> ();
		if (controller.isGrounded) 
		{
			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;
			//本来ならジャンプの処理
		
		}
		if (Input.GetAxis("Vertical")!=0) {
			animator.SetBool ("Running", true);
		} else {
		
			animator.SetBool ("Running", false);
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);

		transform.Rotate (0, Input.GetAxis("Mouse X")*mouse_sense, 0);
		GameObject camera_parent = Camera.main.transform.parent.gameObject;
		camera_parent.transform.Rotate (0, 0, Input.GetAxis ("Mouse Y") * mouse_sense);
	}
}
