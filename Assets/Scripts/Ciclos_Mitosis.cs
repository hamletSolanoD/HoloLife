using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclos_Mitosis : MonoBehaviour
{
    public GameObject[] Fases_Mitosis;
    int Conteo;


    public void setTipoFase(string Fase) {
        switch (Fase) {
            case "Fase_G1": Conteo = 0; break;
            case "Fase_S": Conteo = 1; break;
            case "Fase_G2": Conteo = 2; break;
            case "Profase_Temprana": Conteo = 3; break;
            case "Profase_Tardia": Conteo = 4; break;
            case "Metafase": Conteo = 5; break;
            case "Anafase": Conteo = 6; break;
            case "Telofase": Conteo = 7; break;
            case "Adelante": if (Conteo+1 <= Fases_Mitosis.Length-1) { Conteo++; }
                else { Conteo = 0; }
                    break;
            case "Atras": if (Conteo-1 >= 0){ Conteo--; } break;
            case "Reset":
                reset();
                break;
        }
        reset();
        Fases_Mitosis[Conteo].SetActive(true);
    }

    private void reset(){
        foreach (GameObject g in Fases_Mitosis) { g.SetActive(false); }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
