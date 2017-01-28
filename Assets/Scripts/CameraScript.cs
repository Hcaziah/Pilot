using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

public Camera cameraa;
public Camera camerab;
public bool camToggle = true;
// Use this for initialization
void Start()
{
    camToggle = true;
    cameraa.enabled = true;
    camerab.enabled = false;
}
// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown("c"))
    {
        camToggle = !camToggle;
        cameraa.enabled = !cameraa.enabled;
        camerab.enabled = !camerab.enabled;
    }
}
}
