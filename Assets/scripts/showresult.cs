using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class showresult : MonoBehaviour {

	public distanceText dt;
	public Text txt;
	// Use this for initialization
	void Start () {

		txt.GetComponent<Text> ().text = "Distance:";// + dt.GetComponent<distanceText> ().distance;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
