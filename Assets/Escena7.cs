using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escena7 : MonoBehaviour
{
    string palabra = "ENLACES INFORMATIVOS \n\n Muchas gracias por hacer parte de esta experiencia, para \n saber mas haz click en estos enlaces: \n\n  orem ipsum dolor sit amet, consectetur adipiscing elit, \n sed do eiusmod tempor incididunt ut labore et dolore \n magna aliqua. Ut enim ad minim veniam, quis \n nostruidunt ut labore et dolore magna aliqua. Ut enim ad \n minim veniam, quis nostru ";
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
            yield return new WaitForSeconds(0.0f);
        }

    }
}
