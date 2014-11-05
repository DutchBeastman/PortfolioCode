using UnityEngine;
using System.Collections;

public class CameraZooming : MonoBehaviour {
	bool zoomIn = false;
	bool zoomOut = false;
	
	void Update () {

		///////Zooming In & Out
		switch(zoomIn){
			case true:
				transform.Translate(0, 0, 2);
			break;
		}
		switch(zoomOut){
			case true:
				transform.Translate(0, 0, -2);
			break;
		}

		/////////S & W
		if(Input.GetKeyDown(KeyCode.W))

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
		}
		
		if(Input.GetKeyDown(KeyCode.N))
		{
			Application.LoadLevel("Dead");
		}
	}
}

