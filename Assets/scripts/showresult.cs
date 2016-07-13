using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class showresult : MonoBehaviour {


	public Text txt;
	public Text highscore_text;
	private float highscore;
	private string key = "HIGH_SCORE";
	// Use this for initialization
	void Start () {


        Cursor.visible = true;
		txt.text = "Distance:"+ distanceText.distance;


		//ハイスコアの処理
		highscore = PlayerPrefs.GetFloat (key, -1.0F);
		//値が無いとき
		if (highscore == -1.0F) {
			highscore_text.text = "HIGH SCORE:NONE" ;

			highscore = distanceText.distance;
			PlayerPrefs.SetFloat (key, highscore);
		} else if (distanceText.distance < highscore) {
			//ハイスコア更新
			highscore_text.text = "HIGH SCORE:" + highscore;
			highscore = distanceText.distance;
			PlayerPrefs.SetFloat (key, highscore);
			highscore_text.color = Color.red;
		} else {
		//ハイスコア更新なし
			highscore_text.text = "HIGH SCORE:" + highscore;		
		}
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
