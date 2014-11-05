using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {
	bool rotatingLeft = false;
	bool rotatingRight = false;
	//bool zoomIn = false;
	//bool zoomOut = false;

	void Update () {
		/////Rotating Left & Right
		switch(rotatingLeft){
			case true:
				transform.Rotate(0, 2, 0);
			break;
		}
		switch(rotatingRight){
			case true:
				transform.Rotate(0, -2, 0);
			break;
		}
		///////Zooming In & Out
		/*switch(zoomIn){
			case true:
				transform.Translate(0, 0, 2);
			break;
		}
		switch(zoomOut){
			case true:
				transform.Translate(0, 0, -2);
			break;
		}*/
		/////////A & D
		if(Input.GetKeyDown(KeyCode.A))
		{
			rotatingLeft = true;
		}
		if(Input.GetKeyUp(KeyCode.A))
		{
			rotatingLeft = false;
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			rotatingRight = true;
		}
		if(Input.GetKeyUp(KeyCode.D))
		{
			rotatingRight = false;
		}
		/////////S & W
		/*if(Input.GetKeyDown(KeyCode.W))
		{
			zoomIn = true;
		}
		if(Input.GetKeyUp(KeyCode.W))
		{
			zoomIn = false;
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			zoomOut = true;
		}
		if(Input.GetKeyUp(KeyCode.S))
		{
			zoomOut = false;
		}*/


	}
}
