﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Click : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerClick(int sceneNum){

		Globe.nextSceneName = "ContactLensMenu";  
		Debug.Log("OnPointerClick called.");
		SceneManager.LoadScene(sceneNum);

	}


}
