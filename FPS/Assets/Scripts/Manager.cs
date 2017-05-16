using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	// Public Variables
	public GameObject player;
	public Camera mainCamera;
	public Camera scopeCamera;

	// Use this for initialization
	void Start () {
		scopeCamera.enabled = false;
		mainCamera.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (1)) 
		{
			scopeCamera.enabled = true;
			mainCamera.enabled = false;
		} 
		else 
		{
			scopeCamera.enabled = false;
			mainCamera.enabled = true;
		}
	}
}
