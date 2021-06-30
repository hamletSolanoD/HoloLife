using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Cambiar_Sangre : MonoBehaviour
{
    private string TipoSangre;
    private string Sangre;
   

    public GameObject Sangre_Uno;
    public TextMesh Texto_Sangre_Uno;
    public GameObject Sangre_Dos;
    public TextMesh Texto_Sangre_Dos;




    // Start is called before the first frame update
    void Start()
    {

    }

    public void set_Sangre(string sangre){
        this.Sangre = sangre;
        
}

    public void setTipo(string TipoSangre) {
        this.TipoSangre = TipoSangre;
        if (Sangre == "SANGRE_UNO")
        {
            switch (TipoSangre)
            {
                case "AA":
                    Sangre_Uno.GetComponent<Transform>().name = "TARGET_SANGRE_AA";
                    break;
                case "AO":
                    Sangre_Uno.GetComponent<Transform>().name = "TARGET_SANGRE_AO";
                    break;
                 
                case "OO":
                    Sangre_Uno.GetComponent<Transform>().name = "TARGET_SANGRE_OO";
                    break;
                case "BB":
                    Sangre_Uno.GetComponent<Transform>().name = "TARGET_SANGRE_BB";
                    break;
                case "BO":
                    Sangre_Uno.GetComponent<Transform>().name = "TARGET_SANGRE_BO";
                    break;
                case "AB":
                    Sangre_Uno.GetComponent<Transform>().name = "TARGET_SANGRE_AB";
                    break;
            }
            Texto_Sangre_Uno.text = TipoSangre;
        }
        else if (Sangre == "SANGRE_DOS") {
            switch (TipoSangre)
            {
                case "AA":
                    Sangre_Dos.GetComponent<Transform>().name = "TARGET_SANGRE_AA";
                    break;
                case "AO":
                    Sangre_Dos.GetComponent<Transform>().name = "TARGET_SANGRE_AO";
                    break;

                case "OO":
                    Sangre_Dos.GetComponent<Transform>().name = "TARGET_SANGRE_OO";
                    break;
                case "BB":
                    Sangre_Dos.GetComponent<Transform>().name = "TARGET_SANGRE_BB";
                    break;
                case "BO":
                    Sangre_Dos.GetComponent<Transform>().name = "TARGET_SANGRE_BO";
                    break;
                case "AB":
                    Sangre_Dos.GetComponent<Transform>().name = "TARGET_SANGRE_AB";
                    break;
            }
            Texto_Sangre_Dos.text = TipoSangre;
        }


    }
    }
   


