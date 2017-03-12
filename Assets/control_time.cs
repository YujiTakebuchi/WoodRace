using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control_time : MonoBehaviour {

	float timer = 0;
	public Text timerText;
	bool isPlaying = true;

	// Use this for initialization
	void Start () {
		timerText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isPlaying == true){
			//タイマーに1秒ずつ足していく
			timer += Time.deltaTime;

			//タイマーのテキストにTimer:現在の秒数を代入　
			//変数.ToString()で文字列（String型）に変換できます
			timerText.text = "Timer:" + timer.ToString("f1");
	}
}
}
