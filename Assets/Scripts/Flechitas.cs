using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flechitas : MonoBehaviour
{

    public GameObject[] flechas;
    public TextMeshProUGUI[] misiones;
    public TextMeshProUGUI contadorSinDescubrir;

    public GameManager gm = null;

    public int numeroSecretosSinDescubrir = 11;

    private bool secret1;
    private bool secret2;
    private bool secret3;
    private bool secret4;
    private bool secret5;
    private bool secret6;
    private bool secret7;
    private bool secret8;
    private bool secret9;
    private bool secret10;
    private bool secret11;


    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        contadorSinDescubrir.text = numeroSecretosSinDescubrir.ToString();

        if ((gm.ArtChic_Friend_ParkourBoy == true || gm.ParkourBoy_Friend_ArtChic == true) && secret1 == false)
        {
            flechas[0].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret1 = true;
            return;
        }

        if (gm.ParkourBoy_Love_PopularGirl == true && secret2 == false)
        {
            flechas[1].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret2 = true;
            return;
        }

        if ((gm.ClassPresident_Friend_PopularGirl == true || gm.PopularGirl_Friend_ClassPresident == true) && secret3 == false)
        {
            flechas[2].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret3 = true;
            return;
        }

        if ((gm.ArtChic_Love_PopularGirl == true || gm.PopularGirl_Love_ArtChic == true) && secret4 == false)
        {
            flechas[3].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret4 = true;
            return;
        }

        if ((gm.BandMember_Love_Sport == true || gm.Sport_Love_BandMember == true) && secret5 == false)
        {
            flechas[4].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret5 = true;
            return;
        }

        if (gm.Esoteric_Friend_ArtChic == true && secret6 == false)
        {
            flechas[5].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret6 = true;
            return;
        }

        if (gm.Esoteric_Love_Stoner == true && secret7 == false)
        {
            flechas[6].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret7 = true;
            return;
        }

        if (gm.BandMember_Friend_PopularGirl == true && secret8 == false)
        {
            flechas[7].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret8 = true;
            return;
        }

        if ((gm.Sport_Friend_ClassPresident == true || gm.ClassPresident_Friend_Sport == true) && secret9 == false)
        {
            flechas[8].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret9 = true;
            return;
        }

        if (gm.Stoner_Friend_Sport == true && secret10 == false)
        {
            flechas[9].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret10 = true;
            return;
        }

        if (gm.Stoner_Friend_Esoteric == true && secret11 == false)
        {
            flechas[10].SetActive(true);
            numeroSecretosSinDescubrir = numeroSecretosSinDescubrir - 1;
            secret11 = true;
            return;
        }

        ///// MISIONES TEXTO

        if (gm.Mision1_Durmiendo == true)
        {
            misiones[0].text = "Misión 1: Se estaban riendo porque se cayó el Choripán y se vio justo por la ventana de detrás mío";                  
            
        }

        else
        {
            misiones[0].text = "Misión 1: ???";            
        }

        ///

        if (gm.Mision2_GloboUFO == true)
        {
            misiones[1].text = "Misión 2: Creo que la chica del afro me mandó el globo UFO solo de buena onda... menos mal";                       
            
        }

        else
        {
            misiones[1].text = "Misión 2: ???";
        }

        ///

        if (gm.Mision3_Lonchera == true)
        {
            misiones[2].text = "Misión 3: Nadie se robó la plata al final. Al tesorero le da miedo contar que se le quedó en un café";                      
            
        }

        else
        {
            misiones[2].text = "Misión 3: ???";
        }

    }
}
