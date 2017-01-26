using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour {

    public Transform Corsair;
    public Transform MainCamera;
    //public float CorsairPosX = GameObject.Find("Corsair").transform.position.x;
    //public float CorsairPosY = GameObject.Find("Corsair").transform.position.y;
    //public float CameraPosX = GameObject.FindGameObjectWithTag("MainCamera").transform.position.x;
    //public float CameraPosY = GameObject.FindGameObjectWithTag("MainCamera").transform.position.y;
    // Use this for initialization
    void Start () {

        /*float CorsairPosX = GameObject.Find("Corsair").transform.position.x;
        float CorsairPosY = GameObject.Find("Corsair").transform.position.y;
        float CameraPosX = GameObject.FindGameObjectWithTag("MainCamera").transform.position.x;
        float CameraPosY = GameObject.FindGameObjectWithTag("MainCamera").transform.position.y;*/
}
	
	// Update is called once per frame
	void Update () {
        /*float CorsairPosX = GameObject.Find("Corsair").transform.position.x;
        float CorsairPosY = GameObject.Find("Corsair").transform.position.y;
        float CameraPosX = GameObject.FindGameObjectWithTag("MainCamera").transform.position.x;
        float CameraPosY = GameObject.FindGameObjectWithTag("MainCamera").transform.position.y;
        //print("Corsair X: " + CorsairPosX + " Y: " + CorsairPosY);
        //print("Corsair X: " + GameObject.Find("Corsair").transform.position.x + " Y: " + GameObject.Find("Corsair").transform.position.y);
        print("Camera X: " + CameraPosX + " Y: " + CameraPosY + " | Corsair X: " + CorsairPosX + " Y: " + CorsairPosY);
        //print("Camera X: " + GameObject.FindGameObjectWithTag("MainCamera").transform.position.x + " Y: " + GameObject.FindGameObjectWithTag("MainCamera").transform.position.y);
        CameraPosY = CorsairPosY;
        //float corsairPosx = GameObject.FindGameObjectWithTag("MainCamera").transform.position.x; // = GameObject.Find("Corsair").transform.position.x;
        CameraPosX = CorsairPosX;*/
        MainCamera.transform.Translate(Corsair.transform.position);

    }
}
