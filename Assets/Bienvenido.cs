using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bienvenido : MonoBehaviour
{
    string palabra = "¡Bienvenido!  En esta actividad podrás viajar al pasado para obtener información sobre los hitos históricos que abarcaron los conceptos de ciudadanía, independencia y libertad.";
    public Text texto;


    void Start()
    {
        StartCoroutine(Reloj());
    }

    IEnumerator Reloj()
    {
        foreach (char caracter in palabra)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.1f);
        }

    }
}
