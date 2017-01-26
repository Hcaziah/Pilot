using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class PosDebug : MonoBehaviour
{
	Text DebugInfo;
    void start() {

	}
    public GameObject Corsair;
    public Text Debug_Velocity_X;
    public Text Debug_Velocity_Y;
    public Text Debug_Vertical_Pos_Y;
    public Text Debug_Horizontal_Pos_X;
    public Text Debug_X_Rotation;
    public Text Debug_y_Rotation;
    public Text Debug_Version;
	void Update()
	{
        float Vertical = Input.GetAxis("Vertical");
        float Horizontal = Input.GetAxis("Horizontal");
        double VerticalPos = Math.Floor(Corsair.transform.position.x);
        double HorizontalPos = Math.Floor(Corsair.transform.position.z);
        double RotationX = Math.Floor(Corsair.transform.rotation.eulerAngles.x);
        double RotationY = Math.Floor(Corsair.transform.rotation.eulerAngles.y);
        Debug_Velocity_X.text = "X Velocity: " + Horizontal;
        Debug_Velocity_Y.text = "Y Velocity: " + Vertical;
        Debug_Vertical_Pos_Y.text = "Y Position: " + HorizontalPos;
        Debug_Horizontal_Pos_X.text = "X Position: " + VerticalPos;
        Debug_X_Rotation.text = "X Rotation: " + RotationX;
        Debug_y_Rotation.text = "Y Rotation: " + RotationY;
        Debug_Version.text = "Debug UI V1";
        
	}
}