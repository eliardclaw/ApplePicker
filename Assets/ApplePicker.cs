using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ApplePicker : MonoBehaviour {
	public GameObject basket;
	public int numero = 3;
	public float basketBottom = -7f;
	public float basketSpace = -2f;
	
	
	//1.    agregar esta variable (esto incluye agregar "using System.Collections.Generic;" (linea 3)
	public List<GameObject> gList;
	
	// Use this for initialization
	void Start () {
		
		//2.    Inicializamos nuestra lista de objetos
		gList = new List<GameObject>();
		
		for(int i=0; i<numero; i++){
			GameObject temp = Instantiate (basket) as GameObject;
			Vector3 posicion = Vector3.zero;
			posicion.y = basketBottom + basketSpace * i;
			temp.transform.position = posicion;
			
			//3.    Agregar la canasta a la lista que tenemos arriba
			gList.Add(temp);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	
	/* Esto es codigo nuevo
	 * 4.    Es una funcion que destruira todas las manzanas y, adicionalmente, quitara una canasta representando tus vidas
	 */
	public void AppleDestroyed () {
		//Empezamos quitando todas las manzanas
		GameObject[] array = GameObject.FindGameObjectsWithTag("Apple");
		foreach( GameObject apple in array ){
			Destroy(apple);
		}
		//Continuamos destruyendo la canasta adecuada, que debemos recordar esiste en la lista gList
		int index = gList.Count-1;
		GameObject tBasket = gList[index];
		gList.RemoveAt(index);
		Destroy(tBasket);
		
		
		//Si nuestras canastas terminan eliminadas, reiniciamos el juego
		if(gList.Count == 0){
			//"ApplePicker" tiene que ser el mismo nombre que tu escena (en la carpeta de assets, es el que se ve como un simbolo de unity
			Application.LoadLevel("ApplePicker");
		}
	}
}
