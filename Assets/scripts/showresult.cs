using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class showresult : MonoBehaviour {


	public Text txt;
	// Use this for initialization
	void Start () {

        Cursor.visible = true;
		txt.text = "Distance:"+ distanceText.distance;

		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
