using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingTower : MonoBehaviour {

	private GameObject target;
	private Vector3 PositionTarget;
	private Vector3 RotatingToZero;
	private Vector3 bulletPos;
	public Transform muzzle;
	public float tijd;
	public List<GameObject> enemiesInRange = new List<GameObject>(); 
	private int EnemieCounter; 
	private bool rotating = false;



	void Start(){
		tijd = 0.1f;
		EnemieCounter = 0;
		RotatingToZero = new Vector3(0,transform.rotation.y,0);
	}
	void FixedUpdate(){

		if(rotating == true)
		{

			tijd -= Time.deltaTime;
			transform.LookAt(target.transform.position);
			if(tijd <= 0)
			{


				GameObject newBullet = Instantiate(Resources.Load("Prefabs/Rocket"),transform.position , Quaternion.identity) as GameObject;
				newBullet.name = "Bullet";

				float newXPos = (newBullet.transform.position.x-target.transform.position.x)*-1;
				float newYPos = (newBullet.transform.position.y-target.transform.position.y)*-1;
				float newZPos = (newBullet.transform.position.z-target.transform.position.z)*-1;
				float bSp = 150;
				newBullet.rigidbody.AddRelativeForce(newXPos*bSp, newYPos*bSp, newZPos*bSp);
				tijd = 0.5f;


			}
		}

	}

	void OnTriggerStay(Collider col)
	{
		rotating = false;
		if(col.name == "Enemy11" ||col.name == "Enemy12" ||col.name == "Enemy2" ||col.name == "Enemy31" ||col.name == "Enemy32"){
			PositionTarget = new Vector3(target.transform.position.z * 100,0,target.transform.position.x * 100);
			target = enemiesInRange[0];
			rotating = true;

		}
	}
	void OnCollisionEnter(Collision col){
		Debug.Log("Swagg");
	}
	void OnTriggerEnter(Collider col)
	{	
		Debug.Log("hasjkl;sjf");
		rotating = false;
		if(col.name == "Enemy11" ||col.name == "Enemy12" ||col.name == "Enemy2" ||col.name == "Enemy31" ||col.name == "Enemy32"){
 
			rotating = true;
			enemiesInRange.Add(col.gameObject);
			target = col.gameObject;
		}
	}

	void OnTriggerExit(Collider col)
	{

		if(col.name == "Enemy11" ||col.name == "Enemy12" ||col.name == "Enemy2" ||col.name == "Enemy31" ||col.name == "Enemy32")
		{
			//transform.rotation = Quaternion.LookRotation(RotatingToZero);
			rotating = false;

			//transform.LookAt(RotatingToZero);
			if(enemiesInRange.Contains(col.gameObject))
			{
				enemiesInRange.Remove(col.gameObject);
			}
		}

	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.N))
		{
			Application.LoadLevel("Dead");
		}


	}
}
