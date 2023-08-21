using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControlDialogos : MonoBehaviour
{
    private Queue <string> colaDialogos;
    Textos texto; 
    //public GameObject cartel;
    [SerializeField] TextMeshProUGUI textoPantalla;
    public GameObject backgroundTexto;
    public GameObject canvasDjTable;
    public GameObject canvasPostIt;

    //public Image cloud;

    void Start()
    {
        colaDialogos = new Queue<string> ();
        //cloud = GetComponent<Image>();
    }

    public void ActivarCartel(Textos textoObjeto)
    {
        gameObject.SetActive(true);
        backgroundTexto.SetActive(true);
        canvasDjTable.SetActive(false);
        canvasPostIt.SetActive(false);
        texto = textoObjeto;
        ActivaTexto();
        
    }

    public void ActivaTexto()
    {
        colaDialogos.Clear();
        foreach (string textoGuardar in texto.arrayTextos)
        {
           colaDialogos.Enqueue(textoGuardar); 
        }
        SiguienteFrase();
    }

    public void SiguienteFrase()
    {
        if (colaDialogos.Count == 0)
        {
            CierraCartel();
            return;
        }

        string fraseActual = colaDialogos.Dequeue();
        textoPantalla.text = fraseActual;
    }

    public void CierraCartel()
    {
        textoPantalla.text = "";
        //gameObject.SetActive(false);
        backgroundTexto.SetActive(false);
        canvasDjTable.SetActive(true);
        canvasPostIt.SetActive(true);
        //gameObject.transform.position = new Vector3 (0,-138,0);
        //cloud.enabled = false;
    }
}
