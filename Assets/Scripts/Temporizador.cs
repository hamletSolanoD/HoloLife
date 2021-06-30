using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour {

	public Slider Velocidad_Tiempo;
	public Text  Anio;
	public GameObject Pasto;
	public GameObject Perrito_Pradera;
	public GameObject Serpiente;
	public GameObject Aguila;
	private float Segundos;
	private int Tiempo;


	void Start (){
		Reset ();
	}

	public void Reset(){
		Tiempo = 0;
		Pasto.SetActive (true);
		Pasto.GetComponent<Pasto> ().Reset ();
		Perrito_Pradera.SetActive(true);
		Perrito_Pradera.GetComponent<Perrito_Pradera> ().Reset ();
		Serpiente.SetActive (true);
		Serpiente.GetComponent<Serpiente> ().Reset ();
		Aguila.SetActive (true);
		Aguila.GetComponent<Aguila> ().Reset ();
	}
	public int GetTiempo(){
		return Tiempo;
	}

	void Update () {
		Segundos = Segundos + (((Time.deltaTime / Time.deltaTime)*Velocidad_Tiempo.value)/60);
		if (Segundos >= 60) {
			Tiempo = Tiempo + 1;
			Segundos = 0;
			Pasto.GetComponent<Pasto> ().Crecer ();
			Perrito_Pradera.GetComponent<Perrito_Pradera> ().Comer ();
			Perrito_Pradera.GetComponent<Perrito_Pradera> ().Definir_Fertilidad ();
			Serpiente.GetComponent<Serpiente> ().Comer();
			Serpiente.GetComponent<Serpiente> ().Definir_Fertilidad();
			Aguila.GetComponent<Aguila> ().Comer();
			Aguila.GetComponent<Aguila> ().Definir_Fertilidad();
		}
		Anio.GetComponent<Text> ().text = Tiempo.ToString ();
	}
}
