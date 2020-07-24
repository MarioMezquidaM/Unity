using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escena2 : MonoBehaviour
{
    string palabra = "¡Todos a sus puestos, listos... a viajar! Con ayuda de la Ruleta del tiempo y por azar encontraremos durante nuestro viaje diferentes hitos, personajes y lugares. ¿Qué información interesante encontrarás? ¿Hallarás algún suceso que aún no conoces? ¿Qué relación tienen estos hitos históricos con los términos independencia, libertad y ciudadanía?";
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
