using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPersonaje : MonoBehaviour
{

    string frase = "¡Hola! Soy el Almatar \n tu compañero en esta \n aventura \n ¿Estás preparado?";
    public Text texto;

   
    void Start()
    {
        StartCoroutine(Reloj()); 
    }

    IEnumerator Reloj()
    {
        foreach(char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }
       
    }

}
