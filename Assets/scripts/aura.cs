using UnityEngine;
using System.Collections;

public class aura : MonoBehaviour {
	//public scoretext st;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		//st.GetComponent<scoretext> ().score++;
		Destroy (gameObject);

	}

}
