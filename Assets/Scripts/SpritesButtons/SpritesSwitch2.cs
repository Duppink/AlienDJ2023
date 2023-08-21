using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class SpritesSwitch2 : MonoBehaviour
{
    public GameManager gm;
    public InteractableButton ib;

    public Sprite upOn;
    public Sprite downOn;
    public Sprite neutral;

    public Sprite buttonDisabled;


    // Update is called once per frame
    void Update()
    {
        // Sprites Switches

        if (gm.lightsValue4 == 7)
        {
            gameObject.GetComponent<Image>().sprite = upOn;
        }

        if (gm.lightsValue4 == 8)
        {
            gameObject.GetComponent<Image>().sprite = downOn;
        }

        if (gm.lightsValue4 == 0)
        {
            gameObject.GetComponent<Image>().sprite = neutral;
        }

        if (ib.enabledButton == false)
        {
            gameObject.GetComponent<Image>().sprite = buttonDisabled;
        }
       
    }
}
