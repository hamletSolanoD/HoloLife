using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mitosis_Meiosis : MonoBehaviour
{
    public Camera CamaraVR;
    public GameObject Menu_1;
    public GameObject MenuMitosis;
    public GameObject MenuMeiosis;
    public GameObject Ciclos_Mitosis;
    public GameObject Ciclos_Meiosis;

   
   
void Start()
    {
        CamaraVR = CamaraVR.GetComponent<Camera>();
    }
    private void Interaccion(Ray Dedo)
    {
        RaycastHit Trayecto;
        if (Physics.Raycast(Dedo, out Trayecto)) {
            string Nombre_Objeto = Trayecto.transform.name;
            switch (Nombre_Objeto) {

                ///////////////////////// MENU PRINCIPAL /////////////////////////
                case "Mitosis":
                    Menu_1.SetActive(false);
                    MenuMitosis.SetActive(true);
                    break;
                case "Meiosis":
                    Menu_1.SetActive(false);
                    MenuMeiosis.SetActive(true);
                    break;
                case "Regresar":
                    Menu_1.SetActive(true);
                    MenuMitosis.SetActive(false);
                    MenuMeiosis.SetActive(false);
                    break;
                /////////////////////// MENU MITOSIS ///////////////////////////////
                case "Mitosis_Fase_G1": MenuMitosis.SetActive(false);  Ciclos_Mitosis.SetActive(true); Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Fase_G1");  break;
                case "Mitosis_Fase_S": MenuMitosis.SetActive(false); Ciclos_Mitosis.SetActive(true); Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Fase_S"); break;
                case "Mitosis_Fase_G2": MenuMitosis.SetActive(false); Ciclos_Mitosis.SetActive(true); Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Fase_G2"); break;

                case "Mitosis_Profase_Temprana": MenuMitosis.SetActive(false); Ciclos_Mitosis.SetActive(true); Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Profase_Temprana"); break;
                case "Mitosis_Profase_Tardia": MenuMitosis.SetActive(false); Ciclos_Mitosis.SetActive(true); Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Profase_Tardia"); break;
                case "Mitosis_Metafase": MenuMitosis.SetActive(false); Ciclos_Mitosis.SetActive(true); Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Metafase"); break;
                case "Mitosis_Anafase": MenuMitosis.SetActive(false); Ciclos_Mitosis.SetActive(true); Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Anafase"); break;
                case "Mitosis_Telofase": MenuMitosis.SetActive(false); Ciclos_Mitosis.SetActive(true); Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Telofase"); break;
                case "Regresar_Mitosis":  Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Reset"); Ciclos_Mitosis.SetActive(false); MenuMitosis.SetActive(true); break;
                /////////////////////// MENU MEIOSIS /////////////////////////////// 
                case "Meiosis_Fase_G1": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Fase_G1"); break;
                case "Meiosis_Fase_S": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Fase_S"); break;
                case "Meiosis_Fase_G2": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Fase_G2"); break;
                case "Regresar_Meiosis": Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Reset"); Ciclos_Meiosis.SetActive(false); MenuMeiosis.SetActive(true); break;

                case "Meiosis_Profase_I": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Profase_I"); break;
                case "Meiosis_Metafase_I": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Metafase_I"); break;
                case "Meiosis_Anafase_I": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Anafase_I"); break;
                case "Meiosis_Telofase_I": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Telofase_I"); break;

                case "Meiosis_Profase_II": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Profase_II"); break;
                case "Meiosis_Metafase_II": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Metafase_II"); break;
                case "Meiosis_Anafase_II": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Anafase_II"); break;
                case "Meiosis_Telofase_II": MenuMeiosis.SetActive(false); Ciclos_Meiosis.SetActive(true); Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Telofase_II"); break;
                /////////////////////// Interface Mitosis /////////////////////////////// 
                case "Mitosis_Adelante": Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Adelante"); break;
                case "Mitosis_Atras": Ciclos_Mitosis.GetComponent<Ciclos_Mitosis>().setTipoFase("Atras"); break;
                /////////////////////// Interface Meiosis /////////////////////////////// 
                case "Meiosis_Adelante": Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Adelante"); break;
                case "Meiosis_Atras": Ciclos_Meiosis.GetComponent<Ciclos_Meiosis>().setTipoFase("Atras"); break;


            }
            Debug.Log(Nombre_Objeto);


        }

    }

    // Update is called once per frame
  void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            
            Ray Dedo = CamaraVR.ScreenPointToRay(Input.GetTouch(0).position);
            Interaccion(Dedo);
            
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Ray click = CamaraVR.ScreenPointToRay(Input.mousePosition);
            Interaccion(click);
        }

    }
}
