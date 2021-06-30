using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pasto : MonoBehaviour {

	public GameObject Ejemplar;
	public Text Pasto_barra;
	private float Cantidad_De_Ejemplar;
	public int Ejemplares_Inicial;

	public float cantidad_De_Crecimiento;
	private bool Capacidad_De_Crecer;


	void Start(){
		Capacidad_De_Crecer = true;
		Cantidad_De_Ejemplar = Ejemplares_Inicial;
	}
	public void Crecer(){
		if (Capacidad_De_Crecer == true) {
			Cantidad_De_Ejemplar = Cantidad_De_Ejemplar + cantidad_De_Crecimiento;
		}
	}
	public void Podar(float podado){
		Cantidad_De_Ejemplar = Cantidad_De_Ejemplar - podado;

	}
	public void Reset(){
		Cantidad_De_Ejemplar = Ejemplares_Inicial;
	}
	public float GetPasto(){
		return Cantidad_De_Ejemplar;
	}
	void Update(){
		if (Cantidad_De_Ejemplar <= 0) {
			Capacidad_De_Crecer = false;
			Ejemplar.SetActive (false);
		} else {
			Capacidad_De_Crecer = true;
			Ejemplar.SetActive (true);
		}
		Pasto_barra.text = Cantidad_De_Ejemplar.ToString();

	}
		
}
