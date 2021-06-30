using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclos_Meiosis : MonoBehaviour
{
    public GameObject[] Fases_Meiosis;
    int Conteo; 

    public void setTipoFase(string Fase)
    {
        switch (Fase)
        {
            case "Fase_G1": Conteo = 0; break;
            case "Fase_S": Conteo = 1; break;
            case "Fase_G2": Conteo = 2; break;
           

            case "Profase_I": Conteo = 3; break;
            case "Metafase_I": Conteo = 4; break;
            case "Anafase_I": Conteo = 5;  break;
            case "Telofase_I": Conteo = 6;  break;

            case "Profase_II": Conteo = 7;  break;
            case "Metafase_II": Conteo = 8;  break;
            case "Anafase_II": Conteo = 9; break;
            case "Telofase_II": Conteo = 10;  break;

            case "Adelante":

                if (Conteo + 1 <= Fases_Meiosis.Length-1) { Conteo++;}

                else { Conteo = 0; }

                break;

            case "Atras": if (Conteo - 1 >= 0) { Conteo--; } break;
          

            case "Reset": reset(); break;   
        }
        reset();
        Fases_Meiosis[Conteo].SetActive(true);
        Debug.Log(Conteo);
    }

    private void reset()
{
    foreach (GameObject g in Fases_Meiosis) { g.SetActive(false); }
}

// Update is called once per frame
void Update()
    {
        
    }
}
