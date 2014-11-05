using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
	public int Health = 10;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Damage()
	{
		Health -= 1;
	}
}
