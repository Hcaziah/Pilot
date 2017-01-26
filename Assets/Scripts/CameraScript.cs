using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
public Camera cameraa;
public Camera camerab;
// Use this for initialization
void Start()
{
    cameraa.enabled = true;
    camerab.enabled = false;
}
// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown("c"))
    {
        cameraa.enabled = !cameraa.enabled;
        camerab.enabled = !camerab.enabled;
    }
}
}
