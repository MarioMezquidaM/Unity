using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text tiempoText;
    //public Text fin;
    public GameObject fin;
    public float tiempo = 0.0f;

    void Start ()
    {
        //fin.enabled = false;
        fin.SetActive(false);
    }

    public void Update()
    {
        tiempo -= Time.deltaTime;
        tiempoText.text = "" + tiempo.ToString("f0");

        if(tiempo <= 0)
        {
            tiempoText.text = "0";
            fin.SetActive(true);
        }
        
    }
}
