using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Serpiente : MonoBehaviour {


	public GameObject Ejemplar;
	public Text Score;
	public GameObject Comida;
	public GameObject Tiempo;
	public int Ejemplares_Inicial;
	public int Min_Comida;
	public int Intervalos_Reproduccion;
	public int Cantidad_Crias;
	private int Cantidad_Animal;
	private int Ultima_Reproduccion = 0;

	public int GetSerpiente(){
		return Cantidad_Animal;

	}

	void Start () {
		Cantidad_Animal = Ejemplares_Inicial;
	}

	public void Comer(){
		int comida = (Min_Comida * Cantidad_Animal);
		if (Comida.GetComponent<Perrito_Pradera>().GetPerrito() >= comida) {
			Comida.GetComponent<Perrito_Pradera>().Morir (comida);
		} else {
			Debug.Log (Cantidad_Animal);
			Morir (1);
		}
	}

	public void Morir(int matar){
		Cantidad_Animal = Cantidad_Animal - matar;
	}

	public void Definir_Fertilidad(){
		if ((Tiempo.GetComponent<Temporizador>().GetTiempo() - Ultima_Reproduccion) == Intervalos_Reproduccion ) {
			Ultima_Reproduccion = Tiempo.GetComponent<Temporizador>().GetTiempo ();	
			if( Cantidad_Animal >= 2){
				if(Comida.GetComponent<Perrito_Pradera>().GetPerrito() >= (Min_Comida * Cantidad_Animal)){Reproducirse (); Debug.Log ("Tiempo: " + Tiempo.GetComponent<Temporizador>().GetTiempo() + "una Serpeinte");}

			}
		} 
	}
	public void Reset(){
		Cantidad_Animal = Ejemplares_Inicial;
		Ultima_Reproduccion = 0;

	}
	public void Reproducirse(){
		Cantidad_Animal = Cantidad_Animal + Cantidad_Crias;
	}
	void Update () {
		if (Cantidad_Animal <= 0) {
			Ejemplar.SetActive (false);
		} else {
			Ejemplar.SetActive (true);
		}
		Score.GetComponent<Text> ().text = Cantidad_Animal.ToString ();


	}
}

