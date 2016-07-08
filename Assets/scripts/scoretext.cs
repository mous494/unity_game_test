using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoretext : MonoBehaviour {
	public int score = 0;
	public lastspot ls;
	private bool destroyed = false; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = "Points:" + score.ToString();
		if (score == 5 && destroyed==false) {
			ls.GetComponent<lastspot> ().last = true;
			destroyed = true;
		}


	}
}
