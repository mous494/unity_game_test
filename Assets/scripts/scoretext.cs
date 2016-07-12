using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoretext : MonoBehaviour {
	public int score = 0;
	public lastspot ls;
	private bool destroyed = false;
    private GameObject init;
    private initialset initial_script;
	// Use this for initialization
	void Start () {
        init = GameObject.Find("initial");
        initial_script = init.GetComponent<initialset>();
	
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = "Points:" + score.ToString();
		if (score ==initial_script.length-1  && destroyed==false) {
			ls.GetComponent<lastspot> ().last = true;
			destroyed = true;
		}


	}
}
