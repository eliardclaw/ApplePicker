using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {
	public static float fondo = -20f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < fondo){
			Destroy(this.gameObject);
			
			
			//Mandamos a llamar el metodo en ApplePicker, primero creando una variable y luego corriendo la funcion
			//Ten en mente que AppleDestroyed tiene que escribirse igual que en el C# Script de ApplePicker
			
			ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
			apScript.AppleDestroyed();
		}
	}
}
