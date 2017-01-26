using System.Collections;
/*using System.Collections.Generic;
using System.Runtime.CompilerServices;*/
using UnityEngine;

public class MoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
    public GameObject Corsair;
    public int rotating = 0;
	public float speed = 6;
	public float speedH;
    void Update () {
		if (Input.GetAxis ("Speed") > 0) {
			speedH = speed * (Input.GetAxis ("Speed") + 1) * 2;
		}
		if (Input.GetAxis ("Horizontal") < 0) {
			transform.Translate (-1f * Time.deltaTime * (Input.GetAxis ("Horizontal") * Input.GetAxis ("Horizontal") * speed), 0f, 0f); //Backward
		} 
		if (Input.GetAxis ("Horizontal") > 0) {
			transform.Translate (1f * Time.deltaTime * (Input.GetAxis ("Horizontal") * Input.GetAxis ("Horizontal") * speed), 0f, 0f); //Forward
		} 
		if (Input.GetAxis ("Vertical") < 0) {
            transform.Rotate((-30f * Time.deltaTime * -Input.GetAxis("Vertical")), 0f ,0f);
           if (transform.eulerAngles.x < 345 || transform.eulerAngles.x == 0)
            {
                transform.Translate (0f, 0f, -1f * Time.deltaTime * (Input.GetAxis("Vertical") * Input.GetAxis("Vertical") * speed), Space.World); //Right
                transform.Rotate((30f * Time.deltaTime * -Input.GetAxis("Vertical")), 0f ,0f);
            }
		}
		if (Input.GetAxis ("Vertical") > 0) {
            transform.Rotate((30f * Time.deltaTime * Input.GetAxis("Vertical")), 0f, 0f);
            if (transform.eulerAngles.x > 15 || transform.eulerAngles.x == 0)
            {
                transform.Translate (0f, 0f, 1f * Time.deltaTime * (Input.GetAxis("Vertical") * Input.GetAxis("Vertical") * speed), Space.World); //Left
                transform.Rotate((-30f * Time.deltaTime * -Input.GetAxis("Vertical")), 0f ,0f);
            }
            
        }
        if (Input.GetKeyDown ("q")) {
            transform.position = new Vector3(0, 5, 0);
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
	}
    IEnumerator Sleep()
    {
            yield return new WaitForSeconds(1);
    }
}
