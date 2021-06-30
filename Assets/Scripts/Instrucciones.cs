using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Instrucciones : MonoBehaviour {
	public string[] Textos;
	public Sprite[] Imanegenes;
	public Text info;
	public Image imagen;
	private int index = 0;

	void Start () {
		info.text = Textos [index];
		imagen.sprite = Imanegenes[index];
		
	}
	public void siguiente(){
		index++;
		if(index <= Textos.Length-1){
			info.text = Textos [index];
			imagen.sprite = Imanegenes[index];
		}
		else{
			SceneManager.LoadScene ("Main");

		}
		
	}
	public void Abrir_Navegador(){
		Application.OpenURL ("https://institutoteslacp.wixsite.com/hololife/descargas?fbclid=IwAR3OXtIigeJxPkCO1zDh3c_PDvVmOsGt1bojxavs9m4VDFXPH0w2XCoCGfQ");
	}
	public void Atras(){
		index--;
		if(index >= 0){
			info.text = Textos [index];
			imagen.sprite = Imanegenes[index];
		}
		else{
			SceneManager.LoadScene ("Main");
		}

	}

	void Update () {
		
	}
}
