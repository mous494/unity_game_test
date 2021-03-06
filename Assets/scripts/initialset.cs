﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class initialset : MonoBehaviour {

	//ポイント保持用
	private int[,] points = null;
	int num_point;
	public int length;



	public GameObject aura_prefab;
    private GameObject character;
    private GameObject firstpos;

    // Use this for initialization
	void Start () {
		points=readCSV ("/points.csv");
		for (int i = 1; i < length; i++) {
			//Debug.Log (points [i, 0].ToString () + "," +points [i, 1].ToString ());
			Vector3 pos = new Vector3(points[i,0],0,points[i,1]);
			Instantiate (aura_prefab, pos,Quaternion.identity);		
		
		}
        character =  GameObject.Find("unitychan");
        firstpos = GameObject.Find("firstpos");

        Vector3 chara = new Vector3(points[0, 0], 0, points[0, 1]);


        firstpos.GetComponent<Transform>().position = chara;
        character.GetComponent<CharacterController>().Move(chara);
        character.GetComponent<PlayerMove>().old_pos = chara;
        Cursor.visible = false;
        

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	private int[,] readCSV(string path){
		int[,] readToInt;
		//ストリームリーダーに読み込む
		StreamReader sr = new StreamReader (Application.dataPath + path);
		string strStream = sr.ReadToEnd ();//convert to string

		System.StringSplitOptions option = System.StringSplitOptions.RemoveEmptyEntries;
		string []lines = strStream.Split(new char[]{'\r','\n'},option);//行に分ける

		char []spliter = new char[1]{','};

		//行数指定
		int heightLength =lines.Length;
		int widthLength = lines [0].Split (spliter, option).Length;	

		//戻り値の設定
		readToInt = new int[heightLength,widthLength];
		for (int i = 0; i < heightLength; i++) {
			for (int j = 0; j < widthLength; j++) {
				string[] readStrData = lines [i].Split (spliter, option);
				//キャスト
				readToInt[i,j] = int.Parse(readStrData[j]);
			}	
		}

		this.length = heightLength;

		return readToInt;
	} 
}
