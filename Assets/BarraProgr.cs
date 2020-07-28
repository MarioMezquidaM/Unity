using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraProgr : MonoBehaviour {

    public GameObject imagenCarga;
    public Slider Barra;

    private AsyncOperation asyn;

    //public float max;
    //public float act;
    //public Text valorString;
    //int cont = 0;

    //void Awake()
    //{
    //    Barra = GetComponent<Slider>();
    //}

    public void ClickCarga(int nivel)
    {
        imagenCarga.SetActive(true);
        StartCoroutine(Loadlevelslider(nivel));
        
        //funcionPrueba();
    }

    IEnumerator Loadlevelslider(int nivel)
    {
        asyn = Application.LoadLevelAsync(nivel);
        while (!asyn.isDone)
        {
            Barra.value = asyn.progress;
            yield return null;
            //yield return new WaitForSeconds(5.1f);
        }
    }

    //void Start()
    //{

    //    funcionPrueba();
    //}

    //void Update()
    //{
    //    //ActualizarValorBarra(max, act);
    //}

    //void ActualizarValorBarra(float valorMax, float valorAct)
    //{
    //    float porcentaje;
    //    porcentaje = valorAct / valorMax;
    //    Barra.value = porcentaje;
    //    valorString.text = porcentaje * 100 + "%";
    //}

    //void funcionPrueba()
    //{
    //    if (cont <= 1)
    //    {
    //        ActualizarValorBarra(1, cont);
    //        cont++;
    //    }
    //    else
    //    {
    //        cont = 0;
    //    }
    //    Invoke("funcionPrueba", 5.0f);
    //}
}
