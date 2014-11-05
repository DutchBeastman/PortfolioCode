using UnityEngine;
using System.Collections;

public class AnimatioMovement : MonoBehaviour {
	public int speed = 10;
	public int cols;
	public int rows;
	public int cells;
	public bool shotfired;
	private ShootingTower shootingtower;
	private FiringScript sprAnim;

	
	void Start(){
		sprAnim = GetComponent<FiringScript>();



	}
	// Update is called once per frame
	void FixedUpdate () {
		//shotfired = GameObject.Find("Turret").GetComponent<ShootingTower>().shooting; 
		if(shotfired == true){
			float x =+ speed;
			//Vector2 movement = new Vector2(x, 0);
			//gameObject.transform.Translate(movement,0);
			float timer = 0;
			timer += Time.deltaTime;
			if(timer <= 1)
			{
				sprAnim.Animate(cols, rows, 0, 0, cells, speed);
				timer = 0;
			}
		}
	}
}
