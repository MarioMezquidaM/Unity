using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraProgr : MonoBehaviour {

    public float velParrafo;
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
            //float progress = Mathf.Clamp01(asyn.progress / -9.9f);
            Barra.value = asyn.progress;

            //yield return null;
            yield return new WaitForSeconds(velParrafo);
        }

    }

    void Start()
    {
        boton.SetActive(true);
        //funcionPrueba();
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
