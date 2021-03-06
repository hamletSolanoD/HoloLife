using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cambiar_escena : MonoBehaviour {

    public GameObject Cargando;
    public GameObject Menu;
    public Slider Barra_Cargando;
	//Use this for initialization
	
	public void Cambiar_Y_Cargar (int Nombre_Escena){

        Menu.GetComponent<Canvas>().enabled = false;
        Menu.SetActive(false);
        Cargando.SetActive(true);
        Cargando.GetComponent<Canvas>().enabled = true;
        StartCoroutine(EscenaDeCarga(Nombre_Escena));  
        
	}


    IEnumerator EscenaDeCarga(int Escena_De_Carga) {

        AsyncOperation operation = SceneManager.LoadSceneAsync(Escena_De_Carga);
        
        while (!operation.isDone) {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            Barra_Cargando.value = progress;
            Debug.Log("cargando:" + progress);
         
            yield return null;
        }
    }

    }

