using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_flower_Set_Color : MonoBehaviour {
	

	public Renderer[] rend_Codominancia_1;
	public Renderer[] rend_Codominancia_2;
	public Renderer[] rend_Dominancia_Incompleta_1;
	public Renderer[] rend_Dominancia_Incompleta_2;


	public Slider Red;
	public Slider Green;
	public Slider Blue;
	string Planta;



	public void Cargar_Flor(string Planta){
	this.Planta = Planta;

	}

	void Start () {
		Red.value = 0;
		Green.value = 0;
		Blue.value = 0;
	}

	public void Slider_Changed(){
		Debug.Log ("moviendo");
		float rojo = (Red.value / 255);
		float Verde = (Green.value / 255);
		float Azul = (Blue.value / 255);
		switch (Planta) {
		case "COLIDER_DOMINANCIA_INCOMPLETA_1":
			Debug.Log ("deberia de cambiar");
			foreach (Renderer r in rend_Dominancia_Incompleta_1) {
				r.enabled = true;
				r.GetComponent<Renderer>().material.SetColor ("_Color", new Color (rojo, Verde, Azul, 1));
			}
			break;
		case "COLIDER_DOMINANCIA_INCOMPLETA_2":
			Debug.Log ("deberia de cambiar");
			foreach (Renderer r in rend_Dominancia_Incompleta_2) {
				r.enabled = true;
				r.GetComponent<Renderer>().material.SetColor ("_Color", new Color (rojo, Verde, Azul, 1));
			}
			break;
		case "COLIDER_CODOMINANCIA_1":
			Debug.Log ("deberia de cambiar");
			foreach (Renderer r in rend_Codominancia_1) {
				r.enabled = true;
				r.GetComponent<Renderer>().material.SetColor ("_Color", new Color (rojo, Verde, Azul, 1));			}
			break;
		case "COLIDER_CODOMINANCIA_2":
			Debug.Log ("deberia de cambiar");
			foreach (Renderer r in rend_Codominancia_2) {
				r.enabled = true;
				r.GetComponent<Renderer>().material.SetColor ("_Color", new Color (rojo, Verde, Azul, 1));			}
			break;
				
		}
	}
	public void Reset(){
		Planta = "";
		Red.value = 0;
		Green.value = 0;
		Blue.value = 0;

	}

}
