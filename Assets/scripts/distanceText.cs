using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class distanceText : MonoBehaviour {
	public float distance=0;


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text> ().text = "Distance:" + distance.ToString ();

	}
}
