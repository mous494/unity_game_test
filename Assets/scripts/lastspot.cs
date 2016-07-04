using UnityEngine;
using System.Collections;

public class lastspot : MonoBehaviour {
	public bool last=false;
	public PlayerMove pm;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider collider){
		if (last == true) {
			pm.GetComponent<PlayerMove> ().finish = true;
		
		}
	}
}
