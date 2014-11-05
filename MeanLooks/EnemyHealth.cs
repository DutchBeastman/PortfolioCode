using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int healthCounter;
	public int damage;
	// Use this for initialization
	void Start () {
		healthCounter = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if(healthCounter <= 0){
			Destroy(gameObject);
		}
	}
	public void TakeDamage(int damage)
	{
		healthCounter -= damage;
	}
}
