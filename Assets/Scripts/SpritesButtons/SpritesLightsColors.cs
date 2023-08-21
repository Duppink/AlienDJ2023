using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class SpritesLightsColors : MonoBehaviour
{
    public GameManager gm;
    public InteractableButton ib;

    public Sprite lights0;
    public Sprite lights1;
    public Sprite lights2;
    public Sprite lights3;
    public Sprite lights4;

    public Sprite buttonDisabled;

    
    void Update()
    {
        // Sprites Colors Lights

        if (gm.lightsValue1 == 0)
        {
            gameObject.GetComponent<Image>().sprite = lights0;
        }

        if (gm.lightsValue1 == 1)
        {
            gameObject.GetComponent<Image>().sprite = lights1;
        }

        if (gm.lightsValue1 == 2)
        {
            gameObject.GetComponent<Image>().sprite = lights2;
        }

        if (gm.lightsValue1 == 3)
        {
            gameObject.GetComponent<Image>().sprite = lights3;
        }

        if (gm.lightsValue1 == 4)
        {
            gameObject.GetComponent<Image>().sprite = lights4;
        }

        if (ib.enabledButton == false)
        {
            gameObject.GetComponent<Image>().sprite = buttonDisabled;
        }

        
    }
}
