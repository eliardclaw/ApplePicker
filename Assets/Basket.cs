using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour {
	public GUIText scoreGT;
	// Use this for initialization
	void Start () {
		GameObject scoreGO = GameObject.Find("Score");
		scoreGT = scoreGO.GetComponent<GUIText>();
		scoreGT.text="0";
	}
	
	// Update is called once per frame
	void Update () {
		//Control
		Vector3 mouse2D = Input.mousePosition;
		mouse2D.z = -Camera.main.transform.position.z;
		
		Vector3 mouse3D = Camera.main.ScreenToWorldPoint(mouse2D);
		//
		
		
		//Movimiento
		Vector3 posicion = this.transform.position;
		posicion.x = mouse3D.x;
		this.transform.position = posicion;
	}
	
	void OnCollisionEnter(Collision coll){
		GameObject collided = coll.gameObject;
		if(collided.tag == "Apple"){
			print("ouch");
			Destroy(collided);
			int score = int.Parse (scoreGT.text);
			score = score + 100;
			scoreGT.text = score + "";
		}
	}
}
