using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {
	public GameObject apple;
	public float speed = -1f;
	public float direccion = .1f;
	public float segundos = 1f;
	public float limite = 10f;
	// Use this for initialization
	void Start () {
		InvokeRepeating("DropApple",2f,segundos);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 posicion = transform.position;
		posicion.x = posicion.x + speed * Time.deltaTime;
		transform.position = posicion;
		if(posicion.x < -limite){
			speed = Mathf.Abs(speed);
		} else if(posicion.x > limite){
			speed = -Mathf.Abs(speed);
		}
		
	}
	
	void FixedUpdate(){
		if(Random.value < direccion){
			speed = speed *-1;
		}
	}
	
	void DropApple(){
		GameObject app = Instantiate (apple) as GameObject;
		app.transform.position = transform.position;
	}
}
