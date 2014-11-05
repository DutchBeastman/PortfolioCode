using UnityEngine;
using System.Collections;

public class FiringScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void Update(){

	}
	
	// Update is called once per frame
	public void Animate (int colls, int rows, int rowNB, int colNB, int cells, int fps) {
		 
			string mainTex = "_MainTex";
			int index = (int)(fps * Time.time);
			index = index % cells;
			
			float uIndex = index % colls;
			float vIndex = index / colls;
			
			float sizeX =  1f / colls;
			float sizeY =  1f / rows;
			Vector2 size = new Vector2(sizeX, sizeY);
			
			float offsetX = (uIndex + colNB) * size.x;
			float offsetY = (1f - size.y) - (vIndex + rowNB) * size.y;
			Vector2 offset = new Vector2(offsetX, offsetY);
			
			//float offset2 = Time.time * scrollSpeed;
			renderer.material.SetTextureScale(mainTex, size);
			renderer.material.SetTextureOffset(mainTex, offset);
	}
}
