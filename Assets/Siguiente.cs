using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Siguiente : MonoBehaviour
{
    
    public GameObject botonContinue;
    public GameObject botonQuitar;

    public GameObject panelDialogo;
    public GameObject panelDialogo1;
    public GameObject panelDialogo2;

    void Start()
    {
        panelDialogo2.SetActive(false);
        botonQuitar.SetActive(false);
    }

    void Update()
    {
        botonContinue.SetActive(true);
    }
    
    public void ActivarSiguienteP()
    {
        botonContinue.SetActive(false);
        panelDialogo1.SetActive(false);
        panelDialogo2.SetActive(true);
        botonQuitar.SetActive(true);
    }

    public void botonCerrar()
    {
        panelDialogo.SetActive(false);
        botonContinue.SetActive(false);
    }

    //public void Salir()
    //{
    //    print("Saliendo del juego ");
    //}
}
