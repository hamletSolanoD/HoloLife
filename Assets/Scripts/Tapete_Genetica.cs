using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tapete_Genetica : MonoBehaviour {
	private int Tipo_de_Sangre = 0;
	private int Tipo_de_Conejo = 0;


	private int DetectadoSangre = 0;
	private int DetectadoConejo = 0;
	private int Detectado_Dominancia_Inompleta = 0;
	private int Detectado_Codomiancia = 0;


	public GameObject Sangre_AA;
    public GameObject Sangre_AO;
    public GameObject Sangre_BB;
    public GameObject Sangre_BO;
    public GameObject Sangre_AB;
    public GameObject Sangre_OO;
	

	public GameObject Conejo_Himalaya;
	public GameObject Conejo_Silvestre;
	public GameObject Conejo_Chinchilla;
	public GameObject Conejo_Albino;

	public GameObject Dominancia_Petalo_1;
	public GameObject Dominancia_Petalo_2;
		
	public Renderer Codomiancia_Petalo_1;
	public Renderer Codomiancia_Petalo_2;

	public GameObject Flor;

	public Renderer[] Petalos; 
	public Renderer[] Petalos_2; 





	private void OnTriggerEnter(Collider other){
		// OO = 1
        // AO= 3
        // AA = 7
        //BO = 12
        // BB = 20
        // AB = 30

		if (other.gameObject.name == "TARGET_SANGRE_OO") {
			Tipo_de_Sangre = Tipo_de_Sangre + 1;
			DetectadoSangre++;
			Debug.Log ("AGREGADO TARGET_SANGRE_OO");
		}
        if (other.gameObject.name == "TARGET_SANGRE_AO")
        {
            Tipo_de_Sangre = Tipo_de_Sangre + 3;
            DetectadoSangre++;
            Debug.Log("AGREGADO TARGET_SANGRE_AO");
        }
        if (other.gameObject.name == "TARGET_SANGRE_AA") {
			Tipo_de_Sangre = Tipo_de_Sangre + 7;
			Debug.Log ("AGREGADO TARGET_SANGRE_AA");
			DetectadoSangre++;
		}
		if (other.gameObject.name == "TARGET_SANGRE_BO") {
			Tipo_de_Sangre = Tipo_de_Sangre + 12;
			Debug.Log ("AGREGADO TARGET_SANGRE_BO");
			DetectadoSangre++;
		}
        if (other.gameObject.name == "TARGET_SANGRE_BB")
        {
            Tipo_de_Sangre = Tipo_de_Sangre + 20;
            DetectadoSangre++;
            Debug.Log("AGREGADO TARGET_SANGRE_BB");
        }
        if (other.gameObject.name == "TARGET_SANGRE_AB") {
			Tipo_de_Sangre = Tipo_de_Sangre + 30;
			Debug.Log ("AGREGADO TARGET_SANGRE_AB");
			DetectadoSangre++;
		}

		////////////////////////////// CONEJOS //////////////////////////////
		if (other.gameObject.name == "COLIDER_CONEJO_SILVESTRE") {
			if (Tipo_de_Conejo <= 4) {
				Tipo_de_Conejo = 4;
			}
			Debug.Log ("AGREGADO COLIDER_CONEJO_SILVESTRE");
			DetectadoConejo++;
		}

		if (other.gameObject.name == "COLIDER_CONEJO_CHINCHILLA") {
			if (Tipo_de_Conejo <= 3) {
				Tipo_de_Conejo = 3;
			}
			Debug.Log ("AGREGADO COLIDER_CONEJO_CHINCHILLA");
			DetectadoConejo++;
		
		}
		if (other.gameObject.name == "COLIDER_CONEJO_HIMALAYA") {
			if (Tipo_de_Conejo <= 2) {
				Tipo_de_Conejo = 2;
			}
			Debug.Log ("AGREGADO COLIDER_CONEJO_HIMALAYA");
			DetectadoConejo++;

		}
		if (other.gameObject.name == "COLIDER_CONEJO_ALBINO") {
			if (Tipo_de_Conejo <= 1) {
				Tipo_de_Conejo = 1;
			}
			Debug.Log ("AGREGADO COLIDER_CONEJO_ALBINO");
			DetectadoConejo++;
		}

		///////////////////////////// Codominancia //////////////////////////////
		if (other.gameObject.name == "COLIDER_CODOMINANCIA_1" || other.gameObject.name == "COLIDER_CODOMINANCIA_2") {
			Detectado_Codomiancia++;
		}
		////////////////////////////// dominancia incompleta ////////////////
		if (other.gameObject.name == "COLIDER_DOMINANCIA_INCOMPLETA_1" || other.gameObject.name == "COLIDER_DOMINANCIA_INCOMPLETA_2") {
			Detectado_Dominancia_Inompleta++;
		}
	}


	private void Load3DModel(){
        if (DetectadoSangre == 2) {

            switch (Tipo_de_Sangre) {
        
                case 2: Sangre_OO.SetActive(true); break;
                case 4: Sangre_OO.SetActive(true); Sangre_AO.SetActive(true); break;
                case 6: Sangre_OO.SetActive(true); Sangre_AA.SetActive(true); Sangre_AO.SetActive(true); break;
                case 8:  Sangre_AO.SetActive(true); break;
                case 10: Sangre_AA.SetActive(true); Sangre_AO.SetActive(true); break;
                case 13: Sangre_OO.SetActive(true);  Sangre_BO.SetActive(true); break;
                case 14:  Sangre_AA.SetActive(true);break;
                case 15: Sangre_AB.SetActive(true); Sangre_AO.SetActive(true); Sangre_BO.SetActive(true); Sangre_OO.SetActive(true); break;
                case 19: Sangre_AB.SetActive(true); Sangre_AO.SetActive(true);  break;
                case 21: Sangre_BO.SetActive(true);  break;
                case 23: Sangre_AB.SetActive(true); Sangre_BO.SetActive(true);  break;
                case 24: Sangre_BB.SetActive(true);  Sangre_BO.SetActive(true); Sangre_OO.SetActive(true); break;
                case 27: Sangre_AB.SetActive(true);  break;
                case 31:  Sangre_AO.SetActive(true); Sangre_BO.SetActive(true);  break;
                case 32: Sangre_BO.SetActive(true); Sangre_BB.SetActive(true); break;
                case 33: Sangre_AB.SetActive(true); Sangre_AO.SetActive(true); Sangre_AA.SetActive(true); Sangre_BO.SetActive(true); break;
                case 37: Sangre_AB.SetActive(true);  Sangre_AA.SetActive(true); break;
                case 40: Sangre_BB.SetActive(true);  break;
                case 42: Sangre_AB.SetActive(true); Sangre_AO.SetActive(true); Sangre_BO.SetActive(true); Sangre_BB.SetActive(true); break;
                case 50: Sangre_AB.SetActive(true); Sangre_BB.SetActive(true); break;
                case 60: Sangre_AA.SetActive(true); Sangre_AB.SetActive(true); Sangre_BB.SetActive(true); break;


            }

        }
	


        //////////// CONEJOS ////////////////

        if (Tipo_de_Conejo == 1 && DetectadoConejo == 2) {
			Conejo_Albino.SetActive (true);
		

		}
		else if ( Tipo_de_Conejo == 2 && DetectadoConejo == 2) {
			Conejo_Himalaya.SetActive (true);


		} else if (Tipo_de_Conejo == 3 && DetectadoConejo == 2 ) {
			Conejo_Chinchilla.SetActive (true);

		} else if (Tipo_de_Conejo == 4 && DetectadoConejo == 2) {
			Conejo_Silvestre.SetActive (true);
		}
		////////////////////////////// Codominancia //////////////////////////////
		if(Detectado_Codomiancia == 2){
			Flor.SetActive (true);
			foreach(Renderer r in Petalos){
				r.GetComponent<Renderer> ().material.SetColor ("_Color",Codomiancia_Petalo_1.GetComponent<Renderer>().material.color);
			}
			foreach(Renderer r in Petalos_2){
				r.GetComponent<Renderer> ().material.SetColor ("_Color",Codomiancia_Petalo_2.GetComponent<Renderer>().material.color);
			}
				
		}
		////////////////////////////// Dominancia Incompleta  //////////////////////////////
	
		if(Detectado_Dominancia_Inompleta == 2){
			Flor.SetActive (true);
			float Rojo = (Dominancia_Petalo_1.GetComponent<Renderer> ().material.color.r + Dominancia_Petalo_2.GetComponent<Renderer> ().material.color.r)/2;
			float Verde = (Dominancia_Petalo_1.GetComponent<Renderer> ().material.color.g + Dominancia_Petalo_2.GetComponent<Renderer> ().material.color.g)/2;
			float Azul = (Dominancia_Petalo_1.GetComponent<Renderer> ().material.color.b + Dominancia_Petalo_2.GetComponent<Renderer> ().material.color.b)/2;
			foreach(Renderer r in Petalos){
				r.GetComponent<Renderer> ().material.SetColor ("_Color",new Color(Rojo,Verde,Azul,1));
			}
			foreach(Renderer r in Petalos_2){
				r.GetComponent<Renderer> ().material.SetColor ("_Color",new Color(Rojo,Verde,Azul,1));
			}

		}
	}

	public void Reset(){
		Sangre_AA.SetActive (false);
        Sangre_AO.SetActive(false);
        Sangre_AB.SetActive (false);
		Sangre_BB.SetActive (false);
        Sangre_BO.SetActive(false);
        Sangre_OO.SetActive (false);
	
		Conejo_Himalaya.SetActive (false);
		Conejo_Silvestre.SetActive (false);
		Conejo_Chinchilla.SetActive (false);
		Conejo_Albino.SetActive (false);
		Flor.SetActive (false);
		Tipo_de_Sangre = 0;
		Tipo_de_Conejo = 0;
		DetectadoSangre = 0;
		DetectadoConejo = 0;
		Detectado_Codomiancia = 0;
		Detectado_Dominancia_Inompleta = 0;
	}
		
	void Update () {
		Load3DModel ();
	}
}
