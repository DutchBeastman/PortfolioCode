using UnityEngine;
using System.Collections;

public class GoingToMenu : MonoBehaviour {

	void Update(){
		if(Input.GetKeyDown(KeyCode.N))
		{
			Application.LoadLevel("Menu");
		}
		
		
	}
}
