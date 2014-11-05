using UnityEngine;
using System.Collections;

public class StartButtonScript : MonoBehaviour {
	void Update(){
		if(Input.GetKeyDown(KeyCode.N))
		{
			Application.LoadLevel("LVL1");
		}
		
		
	}
	void OnMouseDown(){
		Application.LoadLevel("LVL1");

	}
}
