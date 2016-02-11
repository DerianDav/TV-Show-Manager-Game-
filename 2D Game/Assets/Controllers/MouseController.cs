using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {

	public GameObject Cursor;

	Vector3 lastFramePosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 currFramePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		currFramePosition.z = 0;

		//Update Cursor Position
		Cursor.transform.position = currFramePosition;


		//Right or Middle Mouse Button
		if(Input.GetMouseButton(1) || Input.GetMouseButton(2)){

			Vector3 diff = lastFramePosition - currFramePosition;
			Camera.main.transform.Translate (diff);
		} 


		lastFramePosition =  Camera.main.ScreenToWorldPoint (Input.mousePosition);
		lastFramePosition.z = 0;
	}
}
