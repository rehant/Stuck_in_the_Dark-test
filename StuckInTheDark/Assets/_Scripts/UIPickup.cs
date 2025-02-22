﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPickup : MonoBehaviour {

	private Text text;
	private Flashlight player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Flashlight>();
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0)
			text.text = "";
		else if (Time.timeScale == 1) {
			if (player.batteryInRange) 
				text.text = "PRESS SPACE TO PICKUP BATTERY";
			else if(player.keyInRange)
				text.text = "PRESS SPACE TO PICKUP KEY";
			else
				text.text = "";
		}
	}
}
