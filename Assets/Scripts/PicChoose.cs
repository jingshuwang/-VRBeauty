using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PicChoose : MonoBehaviour {

	public GameObject lens;
	public Button button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerEnter(){
		
		button.transform.localScale *= 1.6f;
		Debug.Log("OnPointerEnter called.");

	}

	public void OnPointerExit(){

		button.transform.localScale *= 0.625f;
		Debug.Log("OnPointerEnter called.");

	}
		
}
