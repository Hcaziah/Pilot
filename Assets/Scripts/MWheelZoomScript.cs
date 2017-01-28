using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MWheelZoomScript : MonoBehaviour {
	public GameObject Corsair;
	private CameraScript CamScript;
	private bool CamEnabled;
	public Camera myCamera;
	public int FOV = 60;
	// Use this for initialization
	void Start () {
		CamScript = Corsair.GetComponent<CameraScript>();
		CamEnabled = CamScript.camToggle;
	}
	
	// Update is called once per frame
	void Update () {
		//myCamera = new Camera();
		if(CamEnabled == true) {
			print("True");
		}
		if(CamEnabled == true && Input.GetAxis("Mouse ScrollWheel") > 0){
			print("yes");
			myCamera.fieldOfView = FOV--;//"Scrolling Greater then 1!" Scrolling up
		} if (CamEnabled == true && Input.GetAxis("Mouse ScrollWheel") < 0) {
			myCamera.fieldOfView = FOV++;
			//"Scrolling Less then 1!" Scrolling down

		}
	}
}
