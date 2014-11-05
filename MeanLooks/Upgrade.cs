using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {
	//privates

	private bool Upgrade1 = false;
	private Vector3 guiPosition;
	//private Rect windowRect = new Rect(20, 20, 300, 50);//300
	private bool doWindow0 = false;
	private bool doWindow1 = false;
	private int RI = 0;//Rotating It
	private Rect windowRect0 ;
	private Rect windowRect1 ;
	private float posX = 0f;
	private float posZ = 0f;
	private Vector3 rotationTurret;
	private int offsetPos = 20;
	private float TurretRotation;
	private Vector3 PositionsOfTurrets;
	private string UpgradeWindow = "Build Turret";



	//Start making Buttons
	void Start(){
		rotationTurret = new Vector3(0,0,TurretRotation);
		PositionsOfTurrets = new Vector3(transform.position.x + posX,transform.position.y,transform.position.z + posZ);
	}
	void Update(){
		guiPosition = Camera.main.WorldToScreenPoint(transform.position);
		windowRect0 = new Rect(guiPosition.x - 100,  Screen.height - guiPosition.y - 100, 200, 60);
		windowRect1 = new Rect(guiPosition.x - 100,  Screen.height - guiPosition.y - 150, 200, 60);
		if (Input.GetButtonDown("Fire2")){
			doWindow0 = false;
			doWindow1 = false;
		}
	}


	void OnMouseDown(){

		doWindow0 = true;
		//doWindow1 = true;
		if(gameObject.name == "side1")
		{
			posZ = posZ - offsetPos;
			RI = 2;//Rotating It
		}
		if(gameObject.name == "side2")
		{
			posZ = posZ + offsetPos;
			RI = 0;//Rotating It
		}
		if(gameObject.name == "side3")
		{
			posX = posX - offsetPos;
			RI = 1;//Rotating It
		}
		if(gameObject.name == "side4")
		{
			posX = posX + offsetPos;
			RI = 3;//Rotating It
		}

	}
	void OnGUI() {
		//GUI.Window(0, new Rect(guiPosition.x - 100,  Screen.height - guiPosition.y - 150, 200, 60), DoWindow0, "Basic Window");//200
		if(doWindow0){
			GUI.Window(0, new Rect(guiPosition.x - 100,  Screen.height - -guiPosition.y - 150, 200, 60), DoWindow0, "Building Upgrade window");//200
				GUI.color = Color.red;
				windowRect0 = GUI.Window(0, windowRect0, DoWindow0, "Red Window");
		}
		if(doWindow1){	
			GUI.Window(1, new Rect(guiPosition.x - 100,  Screen.height - -guiPosition.y - 150, 200, 90), DoWindow1, "Basic Window");
				GUI.color = Color.green;
				windowRect1 = GUI.Window(1, windowRect1, DoWindow1, "Green Window");
		}
		}
	void DoWindow0(int windowID) {
		if (GUI.Button(new Rect(10, 20, 120, 23), UpgradeWindow)){
			if(!Upgrade1){
				GameObject newTurret = Instantiate(Resources.Load("Prefabs/Cannon"), PositionsOfTurrets, Quaternion.identity) as GameObject;
				newTurret.name = "Turret";
				int NRI = RI * 90;// New Rotating It // Rotating Int
				newTurret.transform.Rotate(0,NRI,0);
				UpgradeWindow = "Damage Upgrade";
			}
			if(Upgrade1)
			{
				
			}
				Upgrade1 = true;
				doWindow0 = false;
		}
	}
	void DoWindow1(int windowID) {
		if (GUI.Button(new Rect(10, 20, 120, 23), UpgradeWindow)){
			
			print("Shiny colors: " + GUI.color);
		}
	}
	}

