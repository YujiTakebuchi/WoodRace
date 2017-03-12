using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click_point : MonoBehaviour {
	int score = 0;
	Text kinoko_text;
	PlayerController pc = new PlayerController();

	// Use this for initialization
	void Start () {
		kinoko_text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
}
}
