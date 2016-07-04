using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class distanceText : MonoBehaviour {
	public float distance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text> ().text = "Distance:" + distance.ToString ();

	}
}
