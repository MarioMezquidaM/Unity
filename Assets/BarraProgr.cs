using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraProgr : MonoBehaviour {
    Slider Barra;

    public float max;
    public float act;
    public Text valorString;
    int cont = 0;

    void Awake(){
        Barra = GetComponent<Slider> ();
    }

    void Start(){
        funcionPrueba();
    }

    void Update(){
        //ActualizarValorBarra(max, act);
    }

    void ActualizarValorBarra(float valorMax, float valorAct){
        float porcentaje;
        porcentaje = valorAct / valorMax;
        Barra.value = porcentaje;
        valorString.text = porcentaje*100 + "%";
    }

    void funcionPrueba(){
        if (cont <= 10){
            ActualizarValorBarra(10, cont);
            cont++;
        } else {
            cont = 0;
        }
        Invoke("funcionPrueba", 1f) ;
    }
}
