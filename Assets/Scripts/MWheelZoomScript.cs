using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MWheelZoomScript : MonoBehaviour {
	public GameObject Corsair;
	private CameraScript CamScript;
	public bool CamEnabled = false;
	public Camera myCamera;
	public int FOV = 60;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//myCamera = new Camera();
		if(Input.GetKeyDown("c")){
			CamEnabled = !CamEnabled;
		}
		if (myCamera.fieldOfView == 5) {
			//CamEnabled = false;
			myCamera.fieldOfView = 6;
		}
		if (myCamera.fieldOfView == 110) {
			//CamEnabled = false;
			myCamera.fieldOfView = 109;
		}
		
		if(CamEnabled && Input.GetAxis("Mouse ScrollWheel") > 0){
			myCamera.fieldOfView = FOV--;//"Scrolling Greater then 1!" Scrolling up
		} 
		if (CamEnabled && Input.GetAxis("Mouse ScrollWheel") < 0) {
			myCamera.fieldOfView = FOV++;
			//"Scrolling Less then 1!" Scrolling down

		}
	}
}
