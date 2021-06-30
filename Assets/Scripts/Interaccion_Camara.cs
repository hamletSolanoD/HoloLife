using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaccion_Camara: MonoBehaviour {

	public Camera CamaraVR;
    public GameObject Canvas_Sangre;
	public GameObject Canvas;
	public GameObject GUI_Microorganismos;
	public GameObject GUI_ECOSISTEMA;
	public GameObject GUI_ORGANISMOS;
	public Text Titulo;
	public Text Descripcion;
	public Image Ilustraciono_Microorganismos;
	public Text Titulo_Organismos;
	public Text Descripcion_Organismos;
	public Image Ilustraciono_Organismos;
	public GameObject[] Hecho;
	public GameObject[] Desbloquear;
	public GameObject[] Microorganismos;
	public string[] Titulos_Microorganismos;
	public Sprite[] Imagenes_Microorganismos;
	public string[] Descripcionees_Microorganismos;
	public string[] Titulos_Organismos;
	public Sprite[] Imagenes_Organismos;
	public string[] Descripcionees_Organismos;


	private string Nombre_Objeto;


	void Start () {
		CamaraVR = CamaraVR.GetComponent<Camera> ();
	}
	

	void Interaccion(Ray Dedo){
		RaycastHit Trayecto;
		if (Physics.Raycast (Dedo, out Trayecto)) {
			Nombre_Objeto = Trayecto.transform.name;
			switch (Nombre_Objeto) {
       ///////////////////////////// TAPETE GENETICA  ////////////////////////////////
       
			case "COLIDER_CODOMINANCIA_1":
				Debug.Log ("Presionaste el Codominancia 1");
				Canvas.SetActive (true);
				Canvas.GetComponent<Canvas> ().enabled = true;
				Canvas.GetComponent<GUI_flower_Set_Color> ().Cargar_Flor (Nombre_Objeto);
				break;  
			case "COLIDER_CODOMINANCIA_2":
				Canvas.SetActive (true);
				Canvas.GetComponent<Canvas> ().enabled = true;

				Debug.Log ("Presionaste el Codominancia 2");
				Canvas.GetComponent<GUI_flower_Set_Color> ().Cargar_Flor (Nombre_Objeto);
				break;
			case "COLIDER_DOMINANCIA_INCOMPLETA_1":
				Canvas.SetActive (true);
				Canvas.GetComponent<Canvas> ().enabled = true;

				Debug.Log ("Presionaste el Codominancia Dominancia_Incompleta_1 ");
				Canvas.GetComponent<GUI_flower_Set_Color> ().Cargar_Flor (Nombre_Objeto);
				break;
			case "COLIDER_DOMINANCIA_INCOMPLETA_2":
				Canvas.SetActive (true);
				Canvas.GetComponent<Canvas> ().enabled = true;
				Debug.Log ("Presionaste el Codominancia Dominancia_Incompleta_2 ");
				Canvas.GetComponent<GUI_flower_Set_Color> ().Cargar_Flor (Nombre_Objeto);
				break;
                case "COLIDER_TARGET_SANGRE_UNO":
                    Canvas_Sangre.SetActive(true);
                    Canvas_Sangre.GetComponent<Canvas>().enabled = true;
                    Debug.Log("Presionaste en sangre uno ");
                    Canvas_Sangre.GetComponent<Cambiar_Sangre>().set_Sangre("SANGRE_UNO");
                    break;
                case "COLIDER_TARGET_SANGRE_DOS":
                    Canvas_Sangre.SetActive(true);
                    Canvas_Sangre.GetComponent<Canvas>().enabled = true;
                    Debug.Log("Presionaste en sangre dos ");
                    Canvas_Sangre.GetComponent<Cambiar_Sangre>().set_Sangre("SANGRE_DOS");
                    break;
                ///////////////////////////////////   Microorganismos  Targets  /////////////////////////////
                case "COLIDER_TARGET_AMEBA":
				Hecho [0].SetActive (true);
				Desbloquear [0].SetActive (false);
				Microorganismos [0].SetActive (true);
				Debug.Log ("Presionaste el  TARGET COLIDER_AMEBA ");
				break;
			case "COLIDER_TARGET_PARAMECIUM":
				Hecho [1].SetActive (true);
				Desbloquear [1].SetActive (false);
				Microorganismos [1].SetActive (true);
				Debug.Log ("Presionaste el  TARGET COLIDER_PARAMECIUM ");
				break;
			case "COLIDER_TARGET_ROTIFEROS":
				Hecho [2].SetActive (true);
				Desbloquear [2].SetActive (false);
				Microorganismos [2].SetActive (true);
				Debug.Log ("Presionaste el  TARGET COLIDER_ROTIFEROS ");
				break;
			case "COLIDER_TARGET_VOLVOX":
				Hecho [3].SetActive (true);		
				Desbloquear [3].SetActive (false);
				Microorganismos [3].SetActive (true);
				Debug.Log ("Presionaste el  TARGET COLIDER_VOLVOX ");
				break;
             case "COLIDER_TARGET_VORTICELLA":
                    Hecho[4].SetActive(true);
                    Desbloquear[4].SetActive(false);
                    Microorganismos[4].SetActive(true);
                    Debug.Log("Presionaste el  TARGET COLIDER VORTICELLA ");
                    break;
                case "COLIDER_TARGET_EUGLENA":
                    Hecho[5].SetActive(true);
                    Desbloquear[5].SetActive(false);
                    Microorganismos[5].SetActive(true);
                    Debug.Log("Presionaste el  TARGET COLIDER VORTICELLA ");
                    break;
                case "COLIDER_TARGET_STENTOR":
                    Hecho[6].SetActive(true);
                    Desbloquear[6].SetActive(false);
                    Microorganismos[6].SetActive(true);
                    Debug.Log("Presionaste el  TARGET COLIDER STENTOR ");
                    break;

                ///////////////////////////////////   Microorganismos Objetos   /////////////////////////////

                case "COLIDER_AMEBA":
				GUI_Microorganismos.SetActive (true);
				GUI_Microorganismos.GetComponent<Canvas> ().enabled = true;
				Titulo.GetComponent<Text> ().text = Titulos_Microorganismos [0];
				Descripcion.GetComponent<Text> ().text = Descripcionees_Microorganismos [0];
				Ilustraciono_Microorganismos.GetComponent<Image> ().sprite = Imagenes_Microorganismos [0];
				Debug.Log ("Presionaste el  COLIDER_AMEBA ");
				break;
			case "COLIDER_PARAMECIUM":
				GUI_Microorganismos.SetActive (true);
				GUI_Microorganismos.GetComponent<Canvas> ().enabled = true;
				Titulo.GetComponent<Text> ().text = Titulos_Microorganismos [1];
				Descripcion.GetComponent<Text> ().text = Descripcionees_Microorganismos [1];
				Ilustraciono_Microorganismos.GetComponent<Image> ().sprite = Imagenes_Microorganismos [1];
				Debug.Log ("Presionaste el  COLIDER_PARAMECIUM ");
				break;
			case "COLIDER_ROTIFEROS":
				GUI_Microorganismos.SetActive (true);
				GUI_Microorganismos.GetComponent<Canvas> ().enabled = true;
				Titulo.GetComponent<Text> ().text = Titulos_Microorganismos [2];
				Descripcion.GetComponent<Text> ().text = Descripcionees_Microorganismos [2];
				Ilustraciono_Microorganismos.GetComponent<Image> ().sprite = Imagenes_Microorganismos [2];
				Debug.Log ("Presionaste el  COLIDER_ROTIFEROS ");
				break;
			case "COLIDER_VOLVOX":
				GUI_Microorganismos.SetActive (true);
				GUI_Microorganismos.GetComponent<Canvas> ().enabled = true;
				Titulo.GetComponent<Text> ().text = Titulos_Microorganismos [3];
				Descripcion.GetComponent<Text> ().text = Descripcionees_Microorganismos [3];
				Ilustraciono_Microorganismos.GetComponent<Image> ().sprite = Imagenes_Microorganismos [3];
				Debug.Log ("Presionaste el  COLIDER_VOLVOX ");
				break;
            case "COLIDER_VORTICELLA":
                    GUI_Microorganismos.SetActive(true);
                    GUI_Microorganismos.GetComponent<Canvas>().enabled = true;
                    Titulo.GetComponent<Text>().text = Titulos_Microorganismos[4];
                    Descripcion.GetComponent<Text>().text = Descripcionees_Microorganismos[4];
                    Ilustraciono_Microorganismos.GetComponent<Image>().sprite = Imagenes_Microorganismos[4];
                    Debug.Log("Presionaste el  COLIDER_VORTICELLA ");
                    break;
             case "COLIDER_EUGLENA":
                    GUI_Microorganismos.SetActive(true);
                    GUI_Microorganismos.GetComponent<Canvas>().enabled = true;
                    Titulo.GetComponent<Text>().text = Titulos_Microorganismos[5];
                    Descripcion.GetComponent<Text>().text = Descripcionees_Microorganismos[5];
                    Ilustraciono_Microorganismos.GetComponent<Image>().sprite = Imagenes_Microorganismos[5];
                    Debug.Log("Presionaste el  COLIDER_EUGLENA ");
                    break;
             case "COLIDER_STENTOR":
                    GUI_Microorganismos.SetActive(true);
                    GUI_Microorganismos.GetComponent<Canvas>().enabled = true;
                    Titulo.GetComponent<Text>().text = Titulos_Microorganismos[6];
                    Descripcion.GetComponent<Text>().text = Descripcionees_Microorganismos[6];
                    Ilustraciono_Microorganismos.GetComponent<Image>().sprite = Imagenes_Microorganismos[6];
                    Debug.Log("Presionaste el  COLIDER_STENTOR ");
                    break;
                ///////////////////////////////////   Ecosistema Objetos   /////////////////////////////

                case "COLIDER_PERRITO_PRADERA":
				GUI_ORGANISMOS.SetActive (true);
				GUI_ORGANISMOS.GetComponent<Canvas> ().enabled = true;
				Titulo_Organismos.GetComponent<Text> ().text = Titulos_Organismos [0];
				Descripcion_Organismos.GetComponent<Text> ().text = Descripcionees_Organismos [0];
				Ilustraciono_Organismos.GetComponent<Image> ().sprite = Imagenes_Organismos [0];
				Debug.Log ("Presionaste el  COLIDER_PERRITO_PRADERA ");
				break;
			case "COLIDER_SERPIENTE":
				GUI_ORGANISMOS.SetActive (true);
				GUI_ORGANISMOS.GetComponent<Canvas> ().enabled = true;
				Titulo_Organismos.GetComponent<Text> ().text = Titulos_Organismos [1];
				Descripcion_Organismos.GetComponent<Text> ().text = Descripcionees_Organismos [1];
				Ilustraciono_Organismos.GetComponent<Image> ().sprite = Imagenes_Organismos [1];
				Debug.Log ("Presionaste el  COLIDER_SERPIENTE ");
				break;
			case "COLIDER_AGUILA":
				GUI_ORGANISMOS.SetActive (true);
				GUI_ORGANISMOS.GetComponent<Canvas> ().enabled = true;
				Titulo_Organismos.GetComponent<Text> ().text = Titulos_Organismos [2];
				Descripcion_Organismos.GetComponent<Text> ().text = Descripcionees_Organismos [2];
				Ilustraciono_Organismos.GetComponent<Image> ().sprite = Imagenes_Organismos [2];
				Debug.Log ("Presionaste el  COLIDER_AGUILA ");
				break;
			}
		}
	}




	void Update () {
		
		if (Input.touchCount > 0 && Input.touches [0].phase == TouchPhase.Began) {
			Ray Dedo = CamaraVR.ScreenPointToRay (Input.GetTouch (0).position);
			Interaccion(Dedo);
			}
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			Ray click = CamaraVR.ScreenPointToRay (Input.mousePosition);
			Interaccion(click);
		}
	}
	public void Reset(){
		for (int i = 0; i <= (Microorganismos.Length - 1); i++) {
			Hecho [i].SetActive (false);
			Desbloquear [i].SetActive (true);
			Microorganismos [i].SetActive (false);
		}


	}


}
