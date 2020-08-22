using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraProgr : MonoBehaviour {

    //public float velParrafo;

    public GameObject imagenCarga;
    public GameObject boton;
    public GameObject Barraa;
    Slider Barra;

    private AsyncOperation asyn;

    public void ClickCarga(int nivel)
    {

        StartCoroutine(Loadlevelslider(nivel));

        
    }

    IEnumerator Loadlevelslider(int nivel)
    {
        asyn = Application.LoadLevelAsync(nivel);

        
        while (!asyn.isDone)
        {
            
            Barra.value = asyn.progress;

            
            //yield return new WaitForSeconds();
            yield return null;
        }

    }

    void Start()
    {
        boton.SetActive(true);
        
        imagenCarga.SetActive(true);
        Barraa.SetActive(true);
    }

    void Update()
    {
        //boton.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fill"))
        {
            boton.SetActive(true);
        }
    }

}
