using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControlDialogos : MonoBehaviour
{
    private Queue <string> colaDialogos;    
    Textos texto;
    public TextoNombrex textoNombrexs;
    //public GameObject cartel;
    [SerializeField] TextMeshProUGUI textoPantalla;
    [SerializeField] TextMeshProUGUI textoNombreAmarillo;
    [SerializeField] TextMeshProUGUI textoNombreNegro;
    public GameObject backgroundTexto;
    public GameObject canvasDjTable;
    public GameObject canvasPostIt;
    //public ObjetoInteractuable scriptObjetoInteractuable;

    //public Image cloud;

    void Start()
    {
        colaDialogos = new Queue<string> ();
        //cloud = GetComponent<Image>();
        //scriptObjetoInteractuable = GameObject.FindObjectOfType<ObjetoInteractuable> ();
        //scriptObjetoInteractuable.GetComponent<ObjetoInteractuable>();

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

    public void ActivarNombrex(TextoNombrex textoObjetoNombre)
    {
        
        textoNombrexs = textoObjetoNombre;
        textoNombreAmarillo.text = textoNombrexs.nombreDelPersonaje;        
        textoNombreNegro.text = textoNombreAmarillo.text = textoNombrexs.nombreDelPersonaje;

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
        textoNombreAmarillo.text = "";
        textoNombreNegro.text = "";
        //gameObject.SetActive(false);
        backgroundTexto.SetActive(false);
        canvasDjTable.SetActive(true);
        canvasPostIt.SetActive(true);
        //gameObject.transform.position = new Vector3 (0,-138,0);
        //cloud.enabled = false;
    }
}
